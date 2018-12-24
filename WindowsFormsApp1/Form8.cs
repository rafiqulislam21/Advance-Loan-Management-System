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
    
    public partial class Form8 : Form
    {
        Thread obj;
        MySqlConnection connection = new MySqlConnection("server= localhost; username= root; password=; database= alm;");
        public Form8()
        {
            InitializeComponent();
        }
        private void openform4()
        {
            Form4 f4 = new Form4();
            Application.Run(f4);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            //obj = new Thread(openform4);
            //obj.SetApartmentState(ApartmentState.STA);
            //obj.Start();
        }

        private void btnaddemp_Click(object sender, EventArgs e)
        {
            if (textFirstName.Text == "" || textLastName.Text == "" || txtdesignation.Text == "" || textStreet.Text == "" || textBuilding.Text == "" || textCity.Text == "" || txtblood.Text == "" || textBusinessDetails.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("please enter all the details in the form");

            }

            else
            {
                connection.Open();
                string query = "insert into tbl_employee (empfirstname,emplastname,empdoe,empusername,emppassword,empcity,empstreet,emphouse,emergencydetails,designation,phoneno,bloodgrp) values ('" + textFirstName.Text + "','" + textLastName.Text + "','" + dtpemp.Text + "','" + textusername.Text + "','" + textpassword.Text + "','" + textCity.Text + "','" + textStreet.Text + "','" + textBuilding.Text + "','" + textBusinessDetails.Text + "','" + txtdesignation.Text + "','" + txtphone.Text + "','" + txtblood.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Successfully added an employee");

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
