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
    public partial class frmLogin : Form
    {
        // Connection String "cs"
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;

            switch(check)
            {
                case true :
                    textBox2.UseSystemPasswordChar = false;
                    break;

                default :
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            string cs = @"Data Source=DESKTOP-A0I46IF\SQLEXPRESS;Initial Catalog=pos_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from login_tbl where username = @user and pass = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);

            con.Open();

            // execute

            SqlDataReader dr = cmd.ExecuteReader();

            // check condition

            if(dr.HasRows == true)
            {
                MessageBox.Show("Login Sucess!");
                
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

            con.Close();
        }
    }
}
