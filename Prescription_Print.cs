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
using Microsoft.Reporting.WinForms;
namespace Pharmacy_Management_System
{
    public partial class Prescription_Print : Form
    {
        public Prescription_Print()
        {
            InitializeComponent();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        
        }

        public void gridview()
        {

            string sql1 = "select Pid,Pname from tbl_pres";
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
        private void Prescription_Print_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.Text = null;
            comboBox2.Text = null;
            gridview();
            // TODO: This line of code loads data into the 'phm_dbDataSet118.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter8.Fill(this.phm_dbDataSet118.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet117.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter7.Fill(this.phm_dbDataSet117.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet105.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter6.Fill(this.phm_dbDataSet105.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet104.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter5.Fill(this.phm_dbDataSet104.tbl_pres);
            // TODO: This line of code loads data into the 'standarddata.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter4.Fill(this.phm_dbDataSet98.tbl_pres);
           

           this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);

}
        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs f)
        {
            f.DataSources.Add(new ReportDataSource("ds", (object)standarddata.tbl_pmed));

        }

       
        private void button1_Click(object sender, EventArgs g)
        {
            setup();
            if (comboBox1.Text.Length > 0)
            {
                this.tbl_presTableAdapter.Fill(this.standarddata.tbl_pres, Convert.ToInt64(comboBox1.Text));
                // TODO: This line of code loads data into the 'standarddata.tbl_pmed' table. You can move, or remove it, as needed.
                this.tbl_pmedTableAdapter.Fill(this.standarddata.tbl_pmed, Convert.ToInt64(comboBox1.Text));
                this.reportViewer1.RefreshReport();
            }
            else 
            {
                MessageBox.Show("Please Select ID.");
                comboBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setup();
            string xx = Convert.ToString(-1);
           this.tbl_presTableAdapter.Fill(this.standarddata.tbl_pres, Convert.ToInt64(xx));
            // TODO: This line of code loads data into the 'standarddata.tbl_pmed' table. You can move, or remove it, as needed.
            this.tbl_pmedTableAdapter.Fill(this.standarddata.tbl_pmed, Convert.ToInt64(xx));
            
            this.reportViewer1.RefreshReport();
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        void display()
        {

            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            if (comboBox2.Text.Length > 0)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Pid,Pname FROM tbl_pres WHERE [Pname] LIKE '" + comboBox2.Text + "%' ", con);
                sda.Fill(dt);

            }
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 1)
            {
                display();
            }
            else
            {
                MessageBox.Show("Record Not Found.");
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
