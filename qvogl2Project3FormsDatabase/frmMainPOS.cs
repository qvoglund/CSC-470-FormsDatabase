using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qvogl2Project3FormsDatabase
{
    public partial class frmMainPOS : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\source\\repos\\CSC-470-FORMSDATABASE\\qvogl2Project3FormsDatabase\\comboDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
       
        String query;

        public String combo_num { get; set; }
        public String size { get; set; }
        private frmSize popupSize = new frmSize();
        private checkout chkout = new checkout();
        private updateInventory inv = new updateInventory();



        int id = 0;
        double total = 0;
        double TAX = 0.097;
        public frmMainPOS()
        {
            InitializeComponent();
            this.FormClosed += frmMainPOS_FormClosing;
            cmd.Connection = conn;
            newSale();
        }

        public void newSale()
        {
            query = "INSERT INTO sales (total) VALUES (0)";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
            query = "SELECT MAX(Id) FROM sales";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            id = Convert.ToInt32(reader[0].ToString());
            Console.WriteLine(id);
            conn.Close();
            chkout.id = id;

            txtTotal.Text = "";
            tbxLineItems.Text = "";
        }

        private void pbxCombo1_Click(object sender, EventArgs e)
        {
            addItems("1");
        }

        private void pbxFries_Click(object sender, EventArgs e)
        {
            addItems("5");
        }

        private void pbxCombo2_Click(object sender, EventArgs e)
        {
            addItems("2");
        }
        private void pbxCombo3_Click(object sender, EventArgs e)
        {
            addItems("3");
        }
        private void pbxCombo4_Click(object sender, EventArgs e)
        {
            addItems("4");
        }
        private void pbxDrink_Click(object sender, EventArgs e)
        {
            addItems("6");
        }

        private void addItems(String combo)
        {
            popupSize.itemSize = null;
            popupSize.ShowDialog();
            combo_num = combo;
            size = popupSize.itemSize;
            if (size == null)
            {
                return;
            }
            checkInventory(combo, size);


            query = "SELECT * FROM combos, size_price, line_items WHERE combos.combo_num = line_items.combo_num AND size_price.combo_num = " +
                "combos.combo_num AND line_items.combo_num = size_price.combo_num AND size_price.size = line_items.size " +
                "AND line_items.Id = '" + id + "'";

            cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            String menuItem = "";
            String price = "";// reader["price"].ToString();
            String name = ""; //reader["name"].ToString();
            total = 0;

            int i = 0;
            while (reader.Read())
            {

                //Console.WriteLine(reader.GetName(i) + " : " + reader[i].ToString());
                price = (Convert.ToDouble(reader["price"]) * Convert.ToDouble(reader["count"])).ToString("#.00");
                name = reader["name"].ToString();
                size = reader["size"].ToString().Trim();
                combo_num = reader["combo_num"].ToString();


                menuItem += "\r\n" + reader["count"].ToString().Trim() + " x (" + size + ") ";

                if (combo_num == "5" || combo_num == "6")
                {
                    menuItem += name + "\t\t\t         $" + price + "\r\n";
                }
                else
                {
                    menuItem += "Combo #" + combo_num + "\t\t\t         $" + price +
                         "\r\n-" + name + "\r\n-" + size + " fries\r\n-" + size + " coke\r\n";
                }

                tbxLineItems.Text = menuItem;
                total += Convert.ToDouble(price);
                i++;
            }
            conn.Close();

            txtTotal.Text = Math.Round(total * TAX, 2).ToString("C") + "\r\n" + Math.Round(total + total * TAX, 2).ToString("C");
            chkout.sub = (Math.Round(total + total * TAX, 2, MidpointRounding.ToEven)).ToString("N2");
        }

        private void checkInventory(String combo, String size)
        {           
            int combo_num = Convert.ToInt16(combo);
            if (combo_num <= 3)
            {
                inv_helper("SELECT inventory.size, item, sum(count) AS count, quantity FROM line_items JOIN inventory ON line_items.size = inventory.size "
                + "WHERE id = " + id + " AND item <> 'Fish' GROUP BY item, quantity, inventory.size", combo, size);
             }
            else if (combo_num == 4)
            {
                inv_helper("SELECT inventory.size, item, sum(count) AS count, quantity FROM line_items JOIN inventory ON line_items.size = inventory.size "
                + "WHERE id = " + id + " AND item <> 'Burger' GROUP BY item, quantity, inventory.size", combo, size);

            }
            else if (combo_num == 5) 
            {
                inv_helper("SELECT inventory.size, item, sum(count) AS count, quantity FROM line_items JOIN inventory ON line_items.size = inventory.size "
                + "WHERE id = " + id + " AND item = 'French Fry' GROUP BY item, quantity, inventory.size", combo, size);
            } else
            {
                inv_helper("SELECT inventory.size, item, sum(count) AS count, quantity FROM line_items JOIN inventory ON line_items.size = inventory.size "
                + "WHERE id = " + id + " AND item = 'Drink' GROUP BY item, quantity, inventory.size", combo, size);
            }
        }

        private void inv_helper(String query, String combo, String size)
        {
            SqlDataReader reader;
            cmd = new SqlCommand(query, conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            //Console.WriteLine(query);
            if (!reader.HasRows)
            {
                conn.Close();
                if (Convert.ToInt16(combo) <= 3)
                {
                    query = "SELECT * FROM inventory WHERE (size = '" + size + "' AND item = 'French Fry' OR item = 'Drink' AND size = '" + size + "') AND item <> 'Fish'";
                }
                else if (Convert.ToInt16(combo) == 4)
                {
                    query = "SELECT * FROM inventory WHERE size = '" + size + "' AND item <> 'Burger'";
                }
                else if (Convert.ToInt16(combo) == 5)
                {
                    query = "SELECT * FROM inventory WHERE size = '" + size + "' AND item = 'French Fry'";
                }
                else
                {
                    query = "SELECT * FROM inventory WHERE size = '" + size + "' AND ITEM = 'Drink'";
                }

                cmd.CommandText = query;
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt16(reader["quantity"]) < 1)
                    {
                        MessageBox.Show("Invalid number of " + reader["item"].ToString().Trim() + "s in inventory.");
                        conn.Close();
                        return;
                    }

                }

            }
            else
            {
                while (reader.Read())
                {
                    //Console.WriteLine(reader["quantity"].ToString());
                    if (reader.HasRows)
                    {
                        if (Convert.ToInt16(reader["quantity"]) < Convert.ToInt16(reader["count"]))
                        {
                            MessageBox.Show("Invalid number of " + reader["item"].ToString().Trim() + "s in inventory.");
                            conn.Close();
                            return;
                        }
                    }
                }
            }

            conn.Close();
            updateLineItems(combo, size);
                        
        }

        private void updateLineItems(String combo, String size)
        {
            int count = 0;
            combo_num = combo;

            query = "SELECT count FROM line_items WHERE Id = " + id + " AND combo_num = '" + combo + "' AND size = '" + size + "'";
            cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
       
            if (reader.Read())
            {
                count = Convert.ToInt32(reader["count"].ToString());
                count++;
                query = "UPDATE line_items SET count = " + count + " WHERE id = " + id + " AND combo_num = '" + combo + "' AND size = '" + size + "'";
            }
            else
            {
                count = 1;
                query = "INSERT INTO line_items (id, combo_num, size, count) VALUES (" + id + ", '" + combo + "', '" + size + "', " + count + ")";
            }
            Console.WriteLine(query);
            conn.Close();
            //query = "DROP TABLE line_items";
            cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void pbxCheckout_Click(object sender, EventArgs e)
        {
            chkout.mPOS = this;
            chkout.ShowDialog();   
        }

        private void frmMainPOS_Load(object sender, EventArgs e)
        {

        }

        private void frmMainPOS_FormClosing(object sender, EventArgs e)
        {
            String delQuery = "DELETE FROM Sales WHERE id = " + id;
            query = "SELECT * FROM line_items WHERE id = " + id;
            cmd.CommandText = query;
            conn.Open();
            if (cmd.ExecuteScalar() == null)
            {
                conn.Close();
                cmd.CommandText = delQuery;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            inv.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newSale();
        }
    }
}
