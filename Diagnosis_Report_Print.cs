using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Pharmacy_Management_System
{
    public partial class Diagnosis_Report_Print : Form
    {
        public Diagnosis_Report_Print()
        {
            InitializeComponent();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        public void setup()
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Right = 0;
            pg.Margins.Bottom = 0;
            reportViewer1.SetPageSettings(pg);
            //this.reportViewer1.RefreshReport();
        }
        private void Diagnosis_Report_Print_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.Text = null;
            comboBox2.Text = null;
            // TODO: This line of code loads data into the 'phm_dbDataSet120.tbl_diagnosis' table. You can move, or remove it, as needed.
            this.tbl_diagnosisTableAdapter4.Fill(this.phm_dbDataSet120.tbl_diagnosis);
           
            // TODO: This line of code loads data into the 'phm_dbDataSet119.tbl_diagnosis' table. You can move, or remove it, as needed.
            this.tbl_diagnosisTableAdapter3.Fill(this.phm_dbDataSet119.tbl_diagnosis);
            // TODO: This line of code loads data into the 'phm_dbDataSet116.tbl_diagnosis' table. You can move, or remove it, as needed.
            this.tbl_diagnosisTableAdapter2.Fill(this.phm_dbDataSet116.tbl_diagnosis);
            // TODO: This line of code loads data into the 'phm_dbDataSet96.tbl_diagnosis' table. You can move, or remove it, as needed.
            //this.tbl_diagnosisTableAdapter1.Fill(this.phm_dbDataSet96.tbl_diagnosis);
            // TODO: This line of code loads data into the 'Phm_dbDataSet72.tbl_diagnosis' table. You can move, or remove it, as needed.
           // this.tbl_diagnosisTableAdapter.Fill(this.Phm_dbDataSet72.tbl_diagnosis,Convert.ToInt32(comboBox1.Text));
            // TODO: This line of code loads data into the 'Phm_dbDataSet63.tbl_echo' table. You can move, or remove it, as needed.
           // this.tbl_echoTableAdapter.Fill(this.Phm_dbDataSet63.tbl_echo);
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                setup();
                this.tbl_diagnosisTableAdapter1.Fill(this.phm_dbDataSet96.tbl_diagnosis, Convert.ToInt64(comboBox1.Text));
                // this.tbl_diagnosisTableAdapter.Fill(this.Phm_dbDataSet72.tbl_diagnosis, Convert.ToInt32(comboBox1.Text));
                // TODO: This line of code loads data into the 'Phm_dbDataSet63.tbl_echo' table. You can move, or remove it, as needed.
                // this.tbl_echoTableAdapter.Fill(this.Phm_dbDataSet63.tbl_echo);

                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Please Enter ID.");
            }
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setup();
            comboBox1.Text = Convert.ToString(-1);
            this.tbl_diagnosisTableAdapter1.Fill(this.phm_dbDataSet96.tbl_diagnosis, Convert.ToInt64(comboBox1.Text));
          //  this.tbl_diagnosisTableAdapter.Fill(this.Phm_dbDataSet72.tbl_diagnosis, Convert.ToInt32(comboBox1.Text));
           
            this.reportViewer1.RefreshReport();
            reportViewer1.Show();
            comboBox1.Text = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        void display()
        {

            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            if (comboBox2.Text.Length > 0)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT pid,pname FROM tbl_diagnosis WHERE [pname] LIKE '" + comboBox2.Text + "%' ", con);
                sda.Fill(dt);

            }
            dataGridView1.DataSource = dt;
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            display();
        }
    }
}
