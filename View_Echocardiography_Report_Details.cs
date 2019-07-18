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

namespace Pharmacy_Management_System
{
    public partial class View_Echocardiography_Report_Details : Form
    {
        string a;
        public View_Echocardiography_Report_Details(string b)
        {
            InitializeComponent();
            a = b;

        }
        public void gridview()
        {

            string sql1 = "select * from tbl_echo";
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            d1.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        void display()
        {

          
            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            if (textBox1.Text.Length > 0)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_echo WHERE [ID] LIKE '" + textBox1.Text + "%' ", con);
               
                    sda.Fill(dt);
                 
              }

            else if (textBox2.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_echo WHERE [Name] LIKE '" + textBox2.Text + "%' ", con);
                sda.Fill(dt);
               
            }
            else if (textBox3.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_echo WHERE [Diag] LIKE '" + textBox3.Text + "%' ", con);
                sda.Fill(dt);
                
            }

            dataGridView1.DataSource = dt;
        }

        private void View_Echocardiography_Report_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phm_dbDataSet124.tbl_echo' table. You can move, or remove it, as needed.
            this.tbl_echoTableAdapter6.Fill(this.phm_dbDataSet124.tbl_echo);
            // TODO: This line of code loads data into the 'phm_dbDataSet59.tbl_echo' table. You can move, or remove it, as needed.
           // this.tbl_echoTableAdapter5.Fill(this.phm_dbDataSet59.tbl_echo);
            gridview();

           
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void button4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0 && textBox2.Text.Length <= 0 && textBox3.Text.Length <= 0)
            {
                MessageBox.Show("Please Select ID, Name or Diagnosis.");
            }
            else
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    MessageBox.Show("Record Found.");
                }
                else
                {
                    MessageBox.Show("Record Not Found.");

                }

            }
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length <= 0 && textBox1.Text.Length <= 0)
            {
                MessageBox.Show("Please Select ID.");
            }
            else
            {
                if (dataGridView2.Rows.Count > 1)
                {
                    if (comboBox1.Text.Length <= 0 && textBox1.Text.Length <= 0)
                    {

                        MessageBox.Show("Please Select ID or select a row to delete.");
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            SqlConnection conn = new SqlConnection(str);
                            string sql3 = "delete from tbl_echo where [ID]='" + comboBox1.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(sql3, conn);
                            try
                            {

                                conn.Open();
                                cmd3.ExecuteNonQuery();
                                MessageBox.Show("Delete Success.");
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                comboBox1.Text = null;
                                gridview();
                                textBox1.Focus();


                            }
                            catch (Exception)
                            {

                                // MessageBox.Show(o.Message);
                            }
                        }
                        else
                        {


                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                            textBox1.Focus();


                        }



                    }

                }
                else
                {

                    MessageBox.Show("Record Not Found.");
                }
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_echo", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
             saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx|All|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 12;

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;


                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();


                        }
                    }
                    catch             
                    {

                    }
                
                }
                MessageBox.Show("Successfully Saved to the Given Path/Folder.");
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_echoTableAdapter2.FillBy(this.phm_dbDataSet28.tbl_echo);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = textBox1.Text;
                textBox2.Clear();
                textBox3.Clear();
                display();
                string sql1 = "select * from tbl_echo where ID = '" + comboBox1.Text + "'";
                SqlConnection conn = new SqlConnection(str);
                SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
                DataSet ds = new DataSet();
                d1.Fill(ds);
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = ds.Tables[0].ToString();
            }
            catch
            {
                //dataGridView1.DataSource = null;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            display();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection conz = new SqlConnection(str);

            DataTable dtz = new DataTable();
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    comboBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    SqlDataAdapter sdaz = new SqlDataAdapter("SELECT * FROM tbl_echo WHERE [ID] LIKE '" + comboBox1.Text + "'", conz);
                    sdaz.Fill(dtz);
                }
                else
                {
                    MessageBox.Show("Please select a single row or cell.");
                }
            }
            catch
            { 
            }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            View_Echocardiography_Report_Details mb = new View_Echocardiography_Report_Details(a);
            mb.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("All the data will be deleted. \nContinue? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(str);
                string sql3 = "delete from tbl_echo";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                try
                {

                    conn.Open();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Delete Success.");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    comboBox1.Text = null;
                    gridview();
                    textBox1.Focus();


                }
                catch (Exception)
                {

                    // MessageBox.Show(o.Message);
                }
            }
                       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }

