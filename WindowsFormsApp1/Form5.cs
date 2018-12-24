using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        Thread obj;
        MySqlConnection connection = new MySqlConnection("server= localhost; username= root; password=; database= alm;");
        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text == "" || textFirstName.Text == "" || textLastName.Text == "" || textTradeID.Text == "" || textStreet.Text == "" || textBuilding.Text == "" || textCity.Text == "" || textZip.Text == "" || textBusinessDetails.Text == "" || textEmail.Text == "" || textBusinessType.Text == "")
            {
                MessageBox.Show("Please enter all the details in the form to sign up .");

            }

            else
            {
                string query1 = "INSERT INTO tbl_business (companyname,pmfirstname,pmlastname,tradelicenceid,officestreet,officebuildingno,officecity,officezip,businessdetails,pmemail,businesstype,businessuser,businesspass) VALUES ('" + txtCompany.Text + "','" + textFirstName.Text + "','" + textLastName.Text + "','" + textTradeID.Text + "','" + textStreet.Text + "','" + textBuilding.Text + "','" + textCity.Text + "','" + textZip.Text + "','" + textBusinessDetails.Text + "','" + textEmail.Text + "','" + textBusinessType.Text + "','" + textBusinessUser.Text + "','" + textBusinessPass.Text + "')";
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Signup Successful");
                connection.Close();

                this.Close();
                /*objt = new Thread(openform1);
                objt.SetApartmentState(ApartmentState.STA);
                objt.Start();*/
            }
        }
        private void openform1()
        {
            form1 f1 = new form1();
            Application.Run(f1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
