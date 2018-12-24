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
    public partial class Form12 : Form
    {
        Thread obj; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");
        public Form12()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtproductname.Text == "" || txtproductmodel.Text == "" || txtproductdetails.Text == "" || txtproductbrand.Text == ""|| txtmanuname.Text == "" || txtmanuzip.Text == "" || txtmanucountry.Text == "" || txtmanucity.Text == "")
            {
                MessageBox.Show("please enter all the details in the form");

            }
            else
            {
                connection.Open();
                string query = "insert into tbl_product (companyid,productname,productbrand,productmodel,productdetails,manufacturer,manucountry,manucity,manuzip) values ('" + Form3.cid + "','" + txtproductname.Text + "','" + txtproductbrand.Text + "','" + txtproductmodel + "','" + txtproductdetails.Text + "','" + txtmanuname.Text + "','" + txtmanucountry.Text + "','" + txtmanucity.Text + "','" + txtmanuzip.Text + "')";
                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Product added Successfully");
                this.Close();
                
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
