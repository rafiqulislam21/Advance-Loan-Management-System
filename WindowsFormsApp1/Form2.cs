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
    public partial class Form2 : Form
    {
        public static string cid;
        public static string companyname, firstname, lastname, tradelicence, street, building, city, zip, details;
        public static string companyid,message;
        Thread objt; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");


        public Form2()
        {
            InitializeComponent();
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            connection.Open();
            // MessageBox.Show(Form1.User);
            string query2 = "SELECT companyid FROM tbl_business WHERE businessuser='" + form1.User + "'";


            MySqlCommand cmd = new MySqlCommand(query2, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                cid = (mdr.GetString("companyid"));
            }

            mdr.Close();
            string query3 = "SELECT * FROM tbl_application WHERE companyid='" + cid + "'";
            MySqlCommand cmdviewapp = new MySqlCommand(query3, connection);
            cmdviewapp.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewapp);
            dauser.Fill(dtuser);
            dgv2.DataSource = dtuser;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            objt = new Thread(openform6);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           

            connection.Open();
            string query3 = "SELECT empmessage,empname FROM tbl_message WHERE proponentid='" + companyid + "'";
            MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
            cmdviewloan.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
            dauser.Fill(dtuser);
            dgvnews.DataSource = dtuser;
            connection.Close();
        }
        public void openform9()
        {
            Form9 f9 = new Form9();
            Application.Run(f9);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            objt = new Thread(openform9);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }

        private void dgvnews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void openform6()
        {
            Form6 f6 = new Form6();
            Application.Run(f6);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            objt = new Thread(openform3);
            objt.SetApartmentState(ApartmentState.STA);
            objt.Start();
        }
        private void openform3()
        {
            Form3 f3 = new Form3();
            Application.Run(f3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query3 = "SELECT * FROM tbl_loan WHERE companyid='" + cid + "'";
            MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
            cmdviewloan.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
            dauser.Fill(dtuser);
            dgv2.DataSource = dtuser;
            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            connection.Open();
            // MessageBox.Show(Form1.User);
            string query2 = "SELECT * FROM tbl_business WHERE businessuser='" + form1.User + "'";
            

            MySqlCommand cmduser = new MySqlCommand(query2, connection);
            cmduser.ExecuteNonQuery();
            MySqlDataReader mdr1;
            mdr1 = cmduser.ExecuteReader();
            if (mdr1.Read())
            {
                companyid = (mdr1.GetString("companyid"));
                companyname = (mdr1.GetString("companyname"));
                firstname = (mdr1.GetString("pmfirstname"));
                lastname = (mdr1.GetString("pmlastname"));
                tradelicence = (mdr1.GetString("tradelicenceid"));
                street = (mdr1.GetString("officestreet"));
                building = (mdr1.GetString("officebuildingno"));
                city = (mdr1.GetString("officecity"));

                zip = (mdr1.GetString("officezip"));
                details = (mdr1.GetString("businesstype"));

            }
            mdr1.Close();
            string name = firstname + " " + lastname;
            string adress = street+ ", " + building + ", " + city + ", "+ zip + ", " + details;
            lblbusiness.Text = details;
            lblmanager.Text = name;
            lbladress.Text = adress;
            lblcid.Text = companyid;
            lblname.Text = companyname;

            

          




            connection.Close();
            



        }
    }
}
