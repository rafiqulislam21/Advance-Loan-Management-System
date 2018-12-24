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
    public partial class Form9 : Form
    {
        Thread obj;
        MySqlConnection connection = new MySqlConnection("server= localhost; username= root; password=; database= alm;");

        public static string message, cusid, cusname;
        public static string empname = "NULL";
        public static int empid = -1;
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query2 = "SELECT * FROM tbl_business WHERE businessuser='" + form1.User + "'";

            // MessageBox.Show(Form1.User);
            MySqlCommand cmduser = new MySqlCommand(query2, connection);
            cmduser.ExecuteNonQuery();

            MySqlDataReader mdr1;
            message = txtmessage.Text;
            mdr1 = cmduser.ExecuteReader();
            if (mdr1.Read())
            {
                cusname = (mdr1.GetString("companyname"));
                cusid = (mdr1.GetString("companyid"));


            }
            //takes  the  reciever name and ID OF THE message
            mdr1.Close();

            //inserts the message and other necessary details in the tbl_message
            string query1 = "INSERT INTO tbl_message (empmessage,empid,empname,proponentname,proponentid) VALUES ('" + message + "','" + empid + "','" + empname +  "','" + cusname + "','" + cusid + "')";


            MySqlCommand cmdmessage = new MySqlCommand(query1, connection);
            cmdmessage.ExecuteNonQuery();
            MessageBox.Show("Message sent");
            connection.Close();
        }
    }
}
