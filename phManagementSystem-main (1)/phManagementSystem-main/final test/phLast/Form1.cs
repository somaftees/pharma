﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ph
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM users";
            ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count == 0 )
            { 
            
                if(textBox1.Text == "root" && textBox2.Text == "root" )
                {
                    Adminstrator am = new Adminstrator();
                    am.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Welcome , please insert the admin.");
                }
            }

            else
            {
                query = "SELECT * FROM users WHERE username='"+ textBox1.Text +"' AND pass='"+textBox2.Text+"'";
                ds = fn.getdata(query);
                if (ds.Tables[0].Rows.Count != 0 )
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Adminstrator")
                    {
                        Adminstrator am = new Adminstrator();
                        am.Show();
                        this.Hide();

                    }
                    else if (role == "Pharmacist")
                    {
                        MessageBox.Show("hi");
                        phproducts ph = new phproducts();
                        ph.Show();
                        this.Hide();

                    }
                }
                else
                    MessageBox.Show("login failed");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
