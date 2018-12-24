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
    public partial class Form6 : Form
    {
        Thread obj; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");
        public Form6()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            

            if (txtCompany.Text == "" || textFirstName.Text == "" || textLastName.Text == "" || textTradeID.Text == "" || textStreet.Text == "" || textBuilding.Text == "" || textCity.Text == "" || textZip.Text == "" || textBusinessDetails.Text == "" || textEmail.Text == "" || textBusinessType.Text == "")
            {
                MessageBox.Show("please enter all the details in the form");

            }

            else
            {
                connection.Open();
                string query = "UPDATE tbl_business SET companyname = '"+txtCompany.Text + "',pmfirstname = '" + textFirstName.Text + "',pmlastname = '" + textLastName.Text + "',tradelicenceid = '" + textTradeID.Text + "',officestreet = '" + textStreet.Text + "',officebuildingno = '" + textBuilding.Text + "',officecity = '" + textCity.Text + "',officezip = '" + textZip.Text + "',businessdetails = '" + textBusinessDetails.Text + "',pmemail = '" + textEmail.Text + "',businesstype = '" + textBusinessType.Text + "' WHERE businessuser ='" + form1.User+"'";
                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
                
                MessageBox.Show("Update successfully done !");
                
            }

        }
        private void openform2()
        {
            Form2 f2 = new Form2();
            Application.Run(f2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            obj = new Thread(openform2);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
