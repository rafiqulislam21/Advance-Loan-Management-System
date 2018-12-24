using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //for using multithreading
using MySql.Data.MySqlClient; //for using database


namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        Thread obj; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");
        public Form7()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (textFirstName.Text == "" || textLastName.Text == "" || txtdesignation.Text == "" || textStreet.Text == "" || textBuilding.Text == "" || textCity.Text == "" || txtblood.Text == "" || textBusinessDetails.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("please enter all the details in the form");

            }

            else
            {
                connection.Open();
                string query = "UPDATE tbl_employee SET bloodgrp = '" + txtblood.Text + "',empfirstname = '" + textFirstName.Text + "',emplastname = '" + textLastName.Text + "',phoneno = '" + txtphone.Text + "',empstreet = '" + textStreet.Text + "',emphouse = '" + textBuilding.Text + "',empcity = '" + textCity.Text + "',designation = '" + txtdesignation.Text + "',emergencydetails = '" + textBusinessDetails.Text + "' WHERE empusername ='" + form1.User + "'";
                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Update successfully done !");

            }

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void openform4()
        {
            Form4 f4 = new Form4();
            Application.Run(f4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtblood_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBusinessDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBuilding_TextChanged(object sender, EventArgs e)
        {

        }

        private void textStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
