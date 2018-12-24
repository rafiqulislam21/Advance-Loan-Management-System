using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //for using multithreading
using MySql.Data.MySqlClient; //for using database
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        Thread obj; //object of multithreading 
        MySqlConnection connection = new MySqlConnection("server=localhost; username=root; password=; database=alm");
        public Form10()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query3 = "SELECT empmessage,proponentid,proponentname FROM tbl_message where empid = '"+-1+"'";
            MySqlCommand cmdviewloan = new MySqlCommand(query3, connection);
            cmdviewloan.ExecuteNonQuery();
            DataTable dtuser = new DataTable();
            MySqlDataAdapter dauser = new MySqlDataAdapter(cmdviewloan);
            dauser.Fill(dtuser);
            dgvnews.DataSource = dtuser;
            connection.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
