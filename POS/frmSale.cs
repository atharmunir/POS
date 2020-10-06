using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace POS
{
    public partial class frmSale : Form
    {
        string cs = @"Data Source=DESKTOP-A0I46IF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True";

        float tax = 0;
        
        public frmSale()
        {
            InitializeComponent();
            GetItems();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            
        }

        void GetItems()
        {
            
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from items_tbl";
            
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string item_names = dr.GetString(1);
                itemcomboBox.Items.Add(item_names);
            }
            con.Close();
        }

        void GetPrice()
        {
            int price = 0;
            SqlConnection con = new SqlConnection(cs);
            string query = "select item_price from items_tbl where item_name = @name";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", itemcomboBox.SelectedItem.ToString());
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count > 0)
            {
                price = Convert.ToInt32( data.Rows[0]["item_price"]);
            }

            pricetextBox.Text = price.ToString();

            //con.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void itemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();

            quantitytextBox.Enabled = true;
        }

        private void quantitytextBox_TextChanged(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(pricetextBox.Text);
            int discount = Convert.ToInt32(discounttextBox.Text);
            int quantity = Convert.ToInt32(quantitytextBox.Text);
            int subTotal = price * quantity;
            subTotal = subTotal - discount * quantity;

            subtotaltextBox.Text = subTotal.ToString();

        }

        private void subtotaltextBox_TextChanged(object sender, EventArgs e)
        {
            int subTotal = Convert.ToInt32(subtotaltextBox.Text);

            //int tax = 0;
            
            tax =  (float)(subTotal * 0.11) ;

            taxtextBox.Text = tax.ToString();
            


        }
    }
}
