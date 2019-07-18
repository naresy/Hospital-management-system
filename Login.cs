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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string s = txtLoginName.Text;

            SqlConnection con = new SqlConnection(@"Data Source=PUSPARAJ;Initial Catalog=Phm_db;User ID=sa;Password=Naresh474210");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_um where Lname = '" + txtLoginName.Text + "' and Password = '" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               

                this.Hide();
               new_main_form f = new new_main_form(s);
               f.Show();
             //   main_form_new n = new main_form_new();
              //  n.ShowDialog();
            }

            else
            {
                MessageBox.Show("Invalid User Name or Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Clear();
                txtPassword.Focus();

            }

            /*  else
              {
                  MessageBox.Show("Invalid User Name or Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

              }
          */



        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Exit? ", "Confirm Exit..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                System.Environment.Exit(0);




            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();

        }

        private void lnkGSoft_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLoginName.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            txtLoginName.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


