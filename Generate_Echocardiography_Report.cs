using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace Pharmacy_Management_System
{
    public partial class Generate_Echocardiography_Report : Form
    {
        public Generate_Echocardiography_Report()

        {
            InitializeComponent();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        public void gridview()
        {

            string sql1 = "select ID,Name from tbl_echo";
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            d1.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        public void setup()
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            
            pg.Margins.Bottom = 0;
            reportViewer1.SetPageSettings(pg);
            //this.reportViewer1.RefreshReport();
        }
       
        private void Generate_Echocardiography_Report_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.Text = null;
            comboBox2.Text = null;
            gridview();
            // TODO: This line of code loads data into the 'phm_dbDataSet115.tbl_echo' table. You can move, or remove it, as needed.
            this.tbl_echoTableAdapter10.Fill(this.phm_dbDataSet115.tbl_echo);
            // TODO: This line of code loads data into the 'phm_dbDataSet114.tbl_echo' table. You can move, or remove it, as needed.
            this.tbl_echoTableAdapter9.Fill(this.phm_dbDataSet114.tbl_echo);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        void display()
        {

            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            if (comboBox2.Text.Length > 0)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT ID,Name FROM tbl_echo WHERE [Name] LIKE '" + comboBox2.Text + "%' ", con);
                sda.Fill(dt);

            }
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setup();
           try
           {
              
                this.tbl_echoTableAdapter8.Fill(this.phm_dbDataSet97.tbl_echo, Convert.ToInt64(comboBox1.Text));
                this.reportViewer1.RefreshReport();
                reportViewer1.Show();
            }
            catch
            { 
            MessageBox .Show ("Please Enter correct ID and try again.");
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generate_Echocardiography_Report e2 = new Generate_Echocardiography_Report();
            e2.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setup();
            comboBox1.Text = Convert.ToString(-1);
            this.tbl_echoTableAdapter8.Fill(this.phm_dbDataSet97.tbl_echo, Convert.ToInt64(comboBox1.Text));
                

            this.reportViewer1.RefreshReport();
            reportViewer1.Show();
            comboBox1.Text = null;
        }
    }
}
