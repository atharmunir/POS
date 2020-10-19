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
    public partial class frmAddItem : Form
        
    {
        string cs = @"Data Source=DESKTOP-A0I46IF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True";

        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into items_tbl values(@name, @price, @discount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", itemtextBox.Text);
            cmd.Parameters.AddWithValue("@price", pricetextBox.Text);
            cmd.Parameters.AddWithValue("@discount", discounttextBox.Text);
            

            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Item Added");
                itemtextBox.Clear();
                pricetextBox.Clear();
                discounttextBox.Clear();
                itemtextBox.Focus();
            }
            else
            {
                MessageBox.Show("Failed to Add!");
            }

            con.Close();
        }
    }
}
