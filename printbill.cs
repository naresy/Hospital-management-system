using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Pharmacy_Management_System
{
    public partial class printbill : Form
    {
        String y;
        public printbill(String r)
        {
             y = r;
            InitializeComponent();
        }

        private void printbill_Load(object sender, EventArgs e)
        {
            textBox1.Text = y;
            setup();
            this.tbl_billTableAdapter.Fill(this.stdata.tbl_bill, Convert.ToInt64(textBox1.Text));
            // TODO: This line of code loads data into the 'stdata.tbl_test' table. You can move, or remove it, as needed.
            this.tbl_testTableAdapter.Fill(this.stdata.tbl_test, Convert.ToInt64(textBox1.Text));

            // this.tbl_billTableAdapter.Fill(this.stdata.tbl_bill,Convert.ToInt64(textBox1.Text));
            // TODO: This line of code loads data into the 'stdata.tbl_test' table. You can move, or remove it, as needed.
            // this.tbl_testTableAdapter.Fill(this.stdata.tbl_test,Convert.ToInt64(textBox1.Text));

            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'stdata.tbl_bill' table. You can move, or remove it, as needed.
            

            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
           
            //this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandle);

            //this.reportViewer1.RefreshReport();
        }
        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs f)
        {
            f.DataSources.Add(new ReportDataSource("DataSet2", (object)stdata.tbl_test));

        }
        public void setup()
        {
            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

            pg.Margins.Bottom = 0;
            reportViewer1.SetPageSettings(pg);
            //this.reportViewer1.RefreshReport();
        }
        private void button7_Click(object sender, EventArgs e)
        {
           /* textBox1.Text = y;
            setup();
            this.tbl_billTableAdapter.Fill(this.stdata.tbl_bill,Convert.ToInt64(textBox1.Text));
            // TODO: This line of code loads data into the 'stdata.tbl_test' table. You can move, or remove it, as needed.
            this.tbl_testTableAdapter.Fill(this.stdata.tbl_test,Convert.ToInt64(textBox1.Text));
           
           // this.tbl_billTableAdapter.Fill(this.stdata.tbl_bill,Convert.ToInt64(textBox1.Text));
            // TODO: This line of code loads data into the 'stdata.tbl_test' table. You can move, or remove it, as needed.
           // this.tbl_testTableAdapter.Fill(this.stdata.tbl_test,Convert.ToInt64(textBox1.Text));
          
           */ //this.reportViewer1.RefreshReport();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbl_billBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        //void SubreportProcessingEventHandle(object sender SubreportProcessingEventArgs f)
    }


}
