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
    public partial class Form11 : Form
    {
        public static string appid, comid, loanamount, loantype, loanissuedate, paymentdeadline, loanrepaid, loanremarks, productid;
        Thread objt; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query3 = "SELECT * FROM tbl_application ";
            MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
            cmdviewloan.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
            dauser.Fill(dtuser);
            display2.DataSource = dtuser;
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query3 = "SELECT * FROM tbl_application WHERE  companyid = '"+txtsearch.Text+"'";
            MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
            cmdviewloan.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
            dauser.Fill(dtuser);
            display2.DataSource = dtuser;
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            string query = "UPDATE tbl_application SET approvalstatus = '" + "true"+ "'";
            MySqlCommand cmd1 = new MySqlCommand(query, connection);
            cmd1.ExecuteNonQuery();
            connection.Close();

            


            string query2 = "SELECT * FROM tbl_application WHERE applicationid='" + txtapprove.Text + "'";
            connection.Open();
            // MessageBox.Show(Form1.User);
            MySqlCommand cmduser = new MySqlCommand(query2, connection);
            cmduser.ExecuteNonQuery();
            MySqlDataReader mdr1;
            mdr1 = cmduser.ExecuteReader();
            if (mdr1.Read())
            {
                appid = (mdr1.GetString("applicationid"));
                comid = (mdr1.GetString("companyid"));
                loanamount = (mdr1.GetString("loanamount"));
                loantype = (mdr1.GetString("loantype"));
                productid = (mdr1.GetString("productid"));

            }
            mdr1.Close();

            loanissuedate = dateloanissue.Text;
            paymentdeadline = cmboxdeadline.Text;
            loanrepaid = txtloanrepaid.Text;
            loanremarks = txtloanremark.Text;



            if (dateloanissue.Text == "" || cmboxdeadline.Text == "Select period" || txtloanrepaid.Text == "" || txtloanremark.Text == "")
            {
                MessageBox.Show("Please fill the boxes to approve !");

            }
            else
            {
                
                string queryinsert = "insert into tbl_loan (applicationid,companyid,loanamount,loantype,loanissuedate,paymentdeadline,loanrepaid,loanremarks,productid) values ('" + appid + "','" + comid + "','" + loanamount + "','" + loantype + "','" + loanissuedate + "','" + paymentdeadline + "','" + loanrepaid + "','" + loanremarks + "','" + productid + "')";
                MySqlCommand cmd = new MySqlCommand(queryinsert, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Application Successful");
                this.Close();
                MessageBox.Show("Approved!");

            }

            



            connection.Close();
        }
    }
}
