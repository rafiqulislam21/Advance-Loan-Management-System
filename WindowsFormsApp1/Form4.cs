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
    public partial class Form4 : Form
    {   
        public static string firstname, lastname,dob, street, building, city, zip, details,empid, empdesi, empblood, empphone,empuser,message,reciever,propname,propid;

        private void btnemployee_Click(object sender, EventArgs e)
        {

            objt = new Thread(openform8);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }
        private void openform8()
        {
            Form8 f8 = new Form8();
            Application.Run(f8);
        }

        private void lbldesi_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            objt = new Thread(openform11);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }
        private void openform11()
        {
            Form11 f11 = new Form11();
            Application.Run(f11);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            objt = new Thread(openform10);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }
        private void openform10()
        {
            Form10 f10 = new Form10();
            Application.Run(f10);
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            empuser = form1.User;
            message = txtempmessage.Text;
            reciever = txtto.Text;
            connection.Open();
            
            string query2 = "SELECT * FROM tbl_business WHERE companyid='" + reciever + "'"; 

            // MessageBox.Show(Form1.User);
            MySqlCommand cmduser = new MySqlCommand(query2, connection);
            cmduser.ExecuteNonQuery();
            
            MySqlDataReader mdr1;
            mdr1 = cmduser.ExecuteReader();
            if (mdr1.Read())
            {
                propname = (mdr1.GetString("companyname"));
                propid = (mdr1.GetString("companyid"));


            }
            //takes  the  reciever name and ID OF THE message
            mdr1.Close();

            //inserts the message and other necessary details in the tbl_message
            string query1 = "INSERT INTO tbl_message (empmessage,empid,empname,proponentname,proponentid) VALUES ('" + message + "','" + empuser + "','" + firstname+"' '"+lastname + "','" + propname + "','" + propid + "')";
            

            MySqlCommand cmdmessage = new MySqlCommand(query1, connection);
            cmdmessage.ExecuteNonQuery();
            MessageBox.Show("Message sent");
            connection.Close();

            





        }

        Thread objt; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");

        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            objt = new Thread(openform1);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void openform1()
        {
            form1 f1 = new form1();
            Application.Run(f1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            objt = new Thread(openform7);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void openform7()
        {
            Form7 f7 = new Form7();
            Application.Run(f7);
        }
            

        private void button5_Click(object sender, EventArgs e)
        {
           if(!rdocompany.Checked && !rdoloan.Checked && !rdoapplication.Checked && !rdoemployee.Checked)
            {
                MessageBox.Show("Please select what you want to search");
            }
            else
            {
                if (rdocompany.Checked )
                {
                    connection.Open();
                    string query3 = "SELECT * FROM tbl_business ";
                    MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
                    cmdviewloan.ExecuteNonQuery();
                    DataTable dtuser = new DataTable();
                    MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
                    dauser.Fill(dtuser);
                    display.DataSource = dtuser;
                    connection.Close();
                }
                else if(rdoapplication.Checked)
                {
                    connection.Open();
                    string query3 = "SELECT * FROM tbl_application ";
                    MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
                    cmdviewloan.ExecuteNonQuery();
                    DataTable dtuser = new DataTable();
                    MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
                    dauser.Fill(dtuser);
                    display.DataSource = dtuser;
                    connection.Close();
                }
                else if(rdoloan.Checked)
                {
                    connection.Open();
                    string query3 = "SELECT * FROM tbl_loan ";
                    MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
                    cmdviewloan.ExecuteNonQuery();
                    DataTable dtuser = new DataTable();
                    MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
                    dauser.Fill(dtuser);
                    display.DataSource = dtuser;
                    connection.Close();
                }
                else if (rdoemployee.Checked)
                {
                    connection.Open();
                    string query3 = "SELECT * FROM tbl_employee ";
                    MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
                    cmdviewloan.ExecuteNonQuery();
                    DataTable dtuser = new DataTable();
                    MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
                    dauser.Fill(dtuser);
                    display.DataSource = dtuser;
                    connection.Close();
                }

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connection.Open();
            // MessageBox.Show(Form1.User);
            string query2 = "SELECT * FROM tbl_employee WHERE empusername='" + form1.User + "'";

           // MessageBox.Show(Form1.User);
            MySqlCommand cmduser = new MySqlCommand(query2, connection);
            cmduser.ExecuteNonQuery();
            MySqlDataReader mdr1;
            mdr1 = cmduser.ExecuteReader();
            if (mdr1.Read())
            {
                empid = (mdr1.GetString("empid"));
                firstname = (mdr1.GetString("empfirstname"));
                lastname = (mdr1.GetString("emplastname"));
                dob = (mdr1.GetString("empdoe"));
                street = (mdr1.GetString("empstreet"));
                building = (mdr1.GetString("emphouse"));
                city = (mdr1.GetString("empcity"));
                details = (mdr1.GetString("emergencydetails"));

                empdesi = (mdr1.GetString("designation"));
                empblood = (mdr1.GetString("bloodgrp"));
                empphone = (mdr1.GetString("phoneno"));

            }
            string name = firstname + " " + lastname;
            string adress = street + ", " + building + ", " + city + ", " + zip ;
            lblmanager.Text = name;
            lbladress.Text = adress;
            lblid.Text = empid;
            lbldob.Text = dob;

            lbldesi.Text = empdesi;
            lblblood.Text = empblood;
            lblphone.Text = empphone;



            connection.Close();
        }
    }
}
