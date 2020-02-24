using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qvogl2Project3FormsDatabase
{
    public partial class checkout : Form
    {
        public frmMainPOS mPOS { get; set; }
        public String sub { get; set; }
        public int id { get; set; }
        double orig_due;
        String query;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\source\\repos\\CSC-470-FORMSDATABASE\\qvogl2Project3FormsDatabase\\comboDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        

        public checkout()
        {
            InitializeComponent();
         
        }

        private Boolean dec_count(String text)
        {
            if (text.Contains("."))
            {
                String[] splitTxt = text.Split('.');
                if (splitTxt[1].Length == 2)
                {
                    return false;
                }
            }
            else if (text.Equals("0"))
            {
                txtInput.Text = "";
            }
            return true;
        }

        private void checkout_Shown(object sender, EventArgs e)
        {
            //Console.WriteLine(sub);
            txtDue.Text = sub;
            orig_due = Convert.ToDouble(sub);
            txtInput.Text = "0";
            txtPaid.Text = "0";
            txtChange.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) { txtInput.Text += "1"; }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "2";}
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "3";}
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "4";}
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "5";}
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "6";}
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "7";}
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "8";}
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) {txtInput.Text += "9";}
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!txtInput.Text.Contains("."))
            {
                txtInput.Text += ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (dec_count(txtInput.Text)) { txtInput.Text += "0"; }
        }

        private void btnDollar_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) + 1).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) + 5).ToString();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) + 10).ToString();
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) + 20).ToString();
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) + 50).ToString();
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            txtInput.Text = (Convert.ToDouble(txtInput.Text) + 100).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double input, due, paid;
            input = Convert.ToDouble(txtInput.Text);
            due = Convert.ToDouble(txtDue.Text);
            paid = Convert.ToDouble(txtPaid.Text);

            if (input > due && due > 0)
            {
                paid += Convert.ToDouble(txtInput.Text);
                txtPaid.Text = paid.ToString("N2");
                txtChange.Text = (paid - orig_due).ToString("N2");
                //Console.WriteLine(orig_due);
                txtDue.Text = "0.00";
            }
            else if (due > 0)
            {
                due -= input;
                txtPaid.Text = (Convert.ToDouble(txtPaid.Text) + input).ToString("N2");
                txtDue.Text = due.ToString("N2");
            }
            txtInput.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTend_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtDue.Text) == 0)
            {
                query = "UPDATE sales SET total = '" + orig_due + "', sale_complete = 1 WHERE id = " + id;
                //Console.WriteLine(query);
                cmd.Connection = conn;
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                update_inventory();
                mPOS.newSale();

                this.Close();
            } else
            {
                MessageBox.Show("Amount Due: $ " + txtDue.Text);
            }
        }

        private void update_inventory()
        {
            query = "WITH counts AS (" +
                "SELECT burger *count AS burger_count, line_items.combo_num, line_items.size, count FROM\n " +
                "line_items RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num WHERE id = \n" + id +
                "GROUP BY burger, line_items.combo_num, line_items.size, line_items.count)\n" +
                "UPDATE inventory SET quantity = (SELECT quantity FROM inventory WHERE item = 'Burger' AND size = 'NA') \n" +
                "- (SELECT sum(counts.burger_count) FROM counts) WHERE(item = 'BURGER' AND size = 'NA');\n" +
                "WITH counts AS(SELECT fish * count AS fish_count, line_items.combo_num, line_items.size, count FROM \n" +
                "line_items RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num WHERE id = " + id + " GROUP BY \n" +
                "fish, line_items.combo_num, line_items.size, line_items.count)\n" +
                "UPDATE inventory SET quantity = (SELECT quantity FROM inventory where item = 'Fish' and size = 'NA') \n" +
                "- (SELECT sum(counts.fish_count) FROM counts) WHERE(item = 'Fish' AND size = 'NA');\n";
            String[] sizes = { "SML", "MED", "LRG" };
            foreach (String item_size in sizes) {
                query += "WITH counts AS (\n" +
                "SELECT french_fry * count AS fry_count, drink * count AS drink_count, line_items.size FROM line_items \n" +
                "RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num WHERE id = " + id + " GROUP BY french_fry, \n" +
                "drink, line_items.combo_num, line_items.size, line_items.count)\n" +
                "UPDATE inventory SET quantity = (SELECT quantity FROM inventory WHERE item = 'French Fry' AND size = '" + item_size + "') \n" +
                "-(SELECT sum(counts.fry_count) FROM counts WHERE size = '" + item_size + "') WHERE size = '" + item_size + "' AND item = 'French Fry';\n";
                query += "WITH counts AS (\n" +
                "SELECT french_fry * count AS fry_count, drink * count AS drink_count, line_items.size FROM line_items \n" +
                "RIGHT OUTER JOIN combos ON line_items.combo_num = combos.combo_num WHERE id = " + id + " GROUP BY french_fry, \n" +
                "drink, line_items.combo_num, line_items.size, line_items.count)\n" +
                "UPDATE inventory SET quantity = (SELECT quantity FROM inventory WHERE item = 'Drink' AND size = '" + item_size + "') \n" +
                "-(SELECT sum(counts.drink_count) FROM counts WHERE size = '" + item_size + "') WHERE size = '" + item_size + "' AND item = 'Drink';\n";
            }
            cmd.Connection = conn;
            cmd.CommandText = query;
            conn.Open();
            //Console.WriteLine(query);
            try
            {
                cmd.ExecuteNonQuery();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
            conn.Close();



        }
        
    }
}
