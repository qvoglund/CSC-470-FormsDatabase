using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace qvogl2Project3FormsDatabase
{
    public partial class updateInventory : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\source\\repos\\CSC-470-FORMSDATABASE\\qvogl2Project3FormsDatabase\\comboDB.mdf;Integrated Security=True;Connect Timeout=30");
        String query = "";
        public updateInventory()
        {
            InitializeComponent();
        }

        private void inventoryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.comboDBDataSet);

        }

        private void updateInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboDBDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.comboDBDataSet.inventory);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String item = txtItem.Text.ToString().Trim();
            String quantity = txtQuantity.Text.ToString().Trim();
            String size = txtSize.Text.ToString().Trim();
            if(item != "" && quantity != "" && size != "")
            {
                try
                {
                    SqlCommand cmd;
                    query = "SELECT * FROM Inventory WHERE size = '" + size + "' AND item = '" + item + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (!rdr.HasRows)
                    {
                        conn.Close();
                        query = "INSERT INTO Inventory VALUES('" + size + "', '" + item + "', '" + quantity + "')";
                        cmd = new SqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Inventory already contains " + size + " " + item);
                        conn.Close();
                    }
                    txtItem.Text = "";
                    txtSize.Text = "";
                    txtQuantity.Text = "";
                    this.inventoryTableAdapter.Update(comboDBDataSet);
                    this.inventoryTableAdapter.Fill(this.comboDBDataSet.inventory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("All fields must be present.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String quantity = quantityTextBox.Text.ToString().Trim();
            int item_id = Convert.ToInt16(item_idTextBox.Text.ToString().Trim());
            String size = sizeTextBox.Text.ToString().Trim();
            String item = itemTextBox.Text.ToString().Trim();

            query = "UPDATE INVENTORY set size = '" + size + "', quantity = '" + quantity + "', item = '" + item +
                    "' WHERE item_id = " + item_id;
            SqlCommand cmd = new SqlCommand(query, conn);
            Console.WriteLine(query);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            this.inventoryTableAdapter.Update(comboDBDataSet);
            this.inventoryTableAdapter.Fill(this.comboDBDataSet.inventory);
      }
    }
}
