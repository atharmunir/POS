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


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
