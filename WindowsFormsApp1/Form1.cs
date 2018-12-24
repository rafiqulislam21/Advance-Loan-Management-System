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
    
    public partial class form1 : Form
    {
        public static string User;
        Thread obj;
        MySqlConnection connection = new MySqlConnection("server= localhost; username= root; password=; database= alm;");
        
        public form1()
        {
            InitializeComponent();
        }
        
        public void openform5()
        {
            Form5 f5 = new Form5();
            Application.Run(f5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Thread(openform5);
            obj.SetApartmentState(ApartmentState.STA);
            obj.Start();
        }
        private void openform2()
        {
            Form2 f2 = new Form2();
            Application.Run(f2);
        }
        private void openform4()
        {
            Form4 f4 = new Form4();
            Application.Run(f4);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please Enter Username !");
                if (txtpassword.Text == "")
                {
                    MessageBox.Show("\nPlease Enter Password !");
                    if (!radioButton1.Checked && !radioButton2.Checked)
                    {
                        MessageBox.Show("\nPlease select user type !");
                    }
                }
                

            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("\nPlease Enter Password !");
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("\nPlease select user type !");
                }
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("\nPlease select user type !");
            }
            // else if (!radioButton1.Checked)
            // {
            //    MessageBox.Show("\nPlease select user type !");
            // }

            else
            {   
                if(radioButton1.Checked)
                {
                    connection.Open();
                    int records = 0;
                    User = txtusername.Text;
                    string query = "SELECT * FROM tbl_business WHERE businessuser='" + txtusername.Text + "' AND businesspass='" + txtpassword.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    records = Convert.ToInt32(dt.Rows.Count.ToString());
                    connection.Close();
                    //MessageBox.Show(records.ToString());
                    if (records == 0)
                    {
                        MessageBox.Show("Mismatch");
                    }
                    else
                    {
                       // MessageBox.Show("Login Successfull");

                        this.Close();
                        obj = new Thread(openform2);
                        obj.SetApartmentState(ApartmentState.STA);
                        obj.Start();
                    }
                }
                else if(radioButton2.Checked)
                {
                    connection.Open();
                    User = txtusername.Text;
                    int records2 = 0;
                    string query2 = "SELECT * FROM tbl_employee WHERE empusername='" + txtusername.Text + "' AND emppassword='" + txtpassword.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    records2 = Convert.ToInt32(dt2.Rows.Count.ToString());
                    connection.Close();
                    //MessageBox.Show(records.ToString());
                    if (records2 == 0)
                    {
                        MessageBox.Show("Mismatch");
                    }
                    else
                    {
                        //MessageBox.Show("Login Successfull");

                        this.Close();
                        obj = new Thread(openform4);
                        obj.SetApartmentState(ApartmentState.STA);
                        obj.Start();
                    }
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
