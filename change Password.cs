using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Management_System
{
    public partial class change_Password : Form
    {
        string b;
        public change_Password(string a)
        {
            InitializeComponent();
            b = a;
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || txtPassword.Text=="")
            {
                label5.Text = "";
                label4.Text = "";
            }
            else
            {
                if (txtPassword.Text == textBox1.Text)
                {
                    label4.Text = "Password matched.";
                    label5.Text = "";
                }
                else
                {
                    label4.Text = "";
                    label5.Text = "Password did not match.";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=pusparaj-pc;Initial Catalog=Phm_db;User ID=sa;Password=naresh474210");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_um where Password = '"+textBox2.Text+"' and Lname= '"+b+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                if (textBox1.Text == txtPassword.Text)
                {


                    SqlCommand cmd = new SqlCommand();
                    con.Open();

                    cmd = new SqlCommand("update tbl_um set Password='" + txtPassword.Text + "' where Password = '" + textBox2.Text + "'", con);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Password is Changed Successfully!");
                    txtPassword.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    con.Close();

                }
                else if (textBox1.Text != txtPassword.Text)
                {

                    MessageBox.Show("Password did not match.");
                    textBox1.Clear();


                }
            }
            else
            {
                MessageBox.Show("Old Password did not match.\n Please Enter Correct Password.");
                textBox2.Clear();

            }
            }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || txtPassword.Text == "")
            {
                label5.Text = "";
                label4.Text = "";
            }
            else
            {
                if (txtPassword.Text == textBox1.Text)
                {
                    label4.Text = "Password matched.";
                    label5.Text = "";
                }
                else
                {
                    label4.Text = "";
                    label5.Text = "Password did not match.";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Ultrasound_Report u = new Ultrasound_Report();
            this.Close();
         
        }

        private void change_Password_Load(object sender, EventArgs e)
        {

        }
        }
    }

