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
    public partial class Form3 : Form
    {
        public static string loantype, loanperiod, date;

        public static string cid;
        Thread obj; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");

        public Form3()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public void openform2()
        {
            Form2 f2 = new Form2();
            Application.Run(f2);
        }

        private void button7_Click(object sender, EventArgs e)
        {


            //MessageBox.Show(cid);
            if (btntypea.Checked)
            {
                loantype = btntypea.Text;
            }
            else if (btntypeb.Checked)
            {
                loantype = btntypeb.Text;
            }
            else
            {
                MessageBox.Show("Please select a loan type");
            }
            loanperiod = cmboperiod.Text;


            if (txtannex.Text == "" || txtloanamount.Text == "" || txtproductid.Text == "" || txtrepaymentacc.Text == "")
            {
                MessageBox.Show("please enter all the details in the form");

            }
            else
            {
                connection.Open();
                string query = "insert into tbl_application (companyid,registrationdate,annexlink,loantype,loanamount,productid,loanperiod,lcaccountnumber,repaymentaccno,approvalstatus) values ('" + cid + "','" + dtp.Text + "','" + txtannex.Text + "','" + loantype + "','" + txtloanamount.Text + "','" + txtproductid.Text + "','" + loanperiod + "','" + txtaccnumber.Text + "','" + txtrepaymentacc.Text + "','" + "false" + "')";
                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Application Successful");
                this.Close();
                obj = new Thread(openform2);
                obj.SetApartmentState(ApartmentState.STA);
                obj.Start();
            }


            //string query1 = "INSERT INTO tbl_application (companyid,registrationdate,annexlink,tradelicenceid,officestreet,officebuildingno,officecity,officezip,businessdetails,pmemail,businesstype,businessuser,businesspass) VALUES ('" + txtCompany.Text + "','" + textFirstName.Text + "','" + textLastName.Text + "','" + textTradeID.Text + "','" + textStreet.Text + "','" + textBuilding.Text + "','" + textCity.Text + "','" + textZip.Text + "','" + textBusinessDetails.Text + "','" + textEmail.Text + "','" + textBusinessType.Text + "','" + textBusinessUser.Text + "','" + textBusinessPass.Text + "')";

        }

        private void btnproductdetails_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query3 = "SELECT * FROM tbl_product WHERE companyid='" + cid + "'";
            MySqlCommand cmd4 = new MySqlCommand(query3, connection);
            cmd4.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd4);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            obj = new Thread(openform2);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtproductid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtrepaymentacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboperiod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtaccnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btntypeb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btntypea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtannex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtloanamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcompanyid_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void openform12()
        {
            Form12 f12 = new Form12();
            Application.Run(f12);
        }

        private void btnproductdetails_Click_1(object sender, EventArgs e)
        {
            obj = new Thread(openform12);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query3 = "SELECT * FROM tbl_product WHERE companyid='" + cid + "'";
            MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
            cmdviewloan.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
            dauser.Fill(dtuser);
            dataGridView1.DataSource = dtuser;
            connection.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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
            } lblcompanyid.Text = cid;
            connection.Close();



        }

        private void openform4()
        {

        }
    }
}
