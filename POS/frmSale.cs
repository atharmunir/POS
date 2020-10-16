﻿using System;
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

        int tax = 0;
        int SrNo = 0;
        int GrandTotal = 0;

        //Constructor
        public frmSale()
        {
            InitializeComponent();
            usertextBox.Text = frmLogin.username;
            GetItems();

            //DataGrid View
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Sr.No.";
            dataGridView1.Columns[1].Name = "Item";
            dataGridView1.Columns[2].Name = "Unit Price";
            dataGridView1.Columns[3].Name = "Discount/item";
            dataGridView1.Columns[4].Name = "Qty";
            dataGridView1.Columns[5].Name = "Sub Total";
            dataGridView1.Columns[6].Name = "Tax";
            dataGridView1.Columns[7].Name = "Total";
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
            if(itemcomboBox.SelectedItem == null)
            {

            }
            else
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
                    price = Convert.ToInt32(data.Rows[0]["item_price"]);
                }

                pricetextBox.Text = price.ToString();
            }
            
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


        //Subtotal
        private void quantitytextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantitytextBox.Text) == true)
            {

            }
            else
            {


                int price = Convert.ToInt32(pricetextBox.Text);
                int discount = Convert.ToInt32(discounttextBox.Text);
                int quantity = Convert.ToInt32(quantitytextBox.Text);
                int subTotal = price * quantity;
                subTotal = subTotal - discount * quantity;

                subtotaltextBox.Text = subTotal.ToString();
            }
        }

        //Add TAX to subtotal
        private void subtotaltextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subtotaltextBox.Text) == true)
            {

            }

            else
            {

            

            int subTotal = Convert.ToInt32(subtotaltextBox.Text);

            //int tax = 0;

            tax = (int)(subTotal * 0.11);

            taxtextBox.Text = tax.ToString();
            }
        }

        //Total with TAX
        private void taxtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taxtextBox.Text) == true)
            {

            }

            else
            {


                int subTotal = Convert.ToInt32(subtotaltextBox.Text);
                int tax = Convert.ToInt32(taxtextBox.Text);
                int totalCost = subTotal + tax;
                totaltextBox.Text = totalCost.ToString();
            }
        }

        //Method to add items in DataGridView (parameterised)
        void AddDataToGridView(string Sr_No, String item_name, string unit_price, string discount, string qty, string sub_total, string tax, string total_cost)
        {
            //Arry for ROW ---- Call this in Add Button
            string[] row = { Sr_No, item_name, unit_price, discount, qty, sub_total, tax, total_cost };
            dataGridView1.Rows.Add(row);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calling AddDataGridView Method
            AddDataToGridView((++SrNo).ToString(),itemcomboBox.SelectedItem.ToString(), pricetextBox.Text, discounttextBox.Text, quantitytextBox.Text, subtotaltextBox.Text, taxtextBox.Text, totaltextBox.Text  ) ;

            ResetContorls();

            //Calling GrandTotal Method

            CalculateGrandTotal();
        }

        //Reset controls after adding item in Grid

        void ResetContorls()
        {
            itemcomboBox.SelectedItem = null;
            pricetextBox.Clear();
            discounttextBox.Clear();
            quantitytextBox.Clear();
            subtotaltextBox.Clear();
            taxtextBox.Clear();
            totaltextBox.Clear();
        }

        //Method to Claculate Grand Total
        void CalculateGrandTotal()
        {
            GrandTotal = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                GrandTotal = GrandTotal + Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value);
            }
            grandtotaltextBox.Text = GrandTotal.ToString();

        }

        private void amountpaidtextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountpaidtextBox.Text) == true)
            {

            }
            else
            {
                int AmountPaid = Convert.ToInt32(amountpaidtextBox.Text);
                int Fcost = Convert.ToInt32( grandtotaltextBox.Text);

                int change = AmountPaid - Fcost;

                changetextBox.Text = change.ToString();
            }
        }
    }
}
