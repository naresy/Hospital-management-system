using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Pharmacy_Management_System
{
    public partial class View_Prescription_Details : Form
    {
        
        public View_Prescription_Details()
        {
            InitializeComponent();
           
            dataGridView2.DataSource = null;
        }

        private void View_Prescription_Details_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_pres", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            // TODO: This line of code loads data into the 'phm_dbDataSet125.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter4.Fill(this.phm_dbDataSet125.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet123.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter3.Fill(this.phm_dbDataSet123.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet122.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter2.Fill(this.phm_dbDataSet122.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet121.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter1.Fill(this.phm_dbDataSet121.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet8med' table. You can move, or remove it, as needed.
            this.tbl_pmedTableAdapter.Fill(this.phm_dbDataSet86.tbl_pmed);

        }


        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        void display()
        {

            SqlConnection con = new SqlConnection(str);
            SqlConnection conz = new SqlConnection(str);
            DataTable dt = new DataTable();
            DataTable dtz = new DataTable();
            if (textBox1.Text.Length > 0)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_pres WHERE [Pid] LIKE '" + textBox1.Text + "%' ", con);
                sda.Fill(dt);
                SqlDataAdapter sdaz = new SqlDataAdapter("SELECT * FROM tbl_pmed WHERE [Pid] LIKE '" + textBox1.Text +"'" , conz);
                sdaz.Fill(dtz);

            }

            else if (textBox2.Text.Length > 0)
            {


                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_pres WHERE [Pname] LIKE '" + textBox2.Text + "%' ", con);
                sda.Fill(dt);

                SqlConnection conp = new SqlConnection(@"Data Source=pusparaj-pc;Initial Catalog=Phm_db;User ID=sa;Password=naresh474210");
                SqlDataAdapter sdap = new SqlDataAdapter("select count(*) from tbl_pres where [Pname] = '" + textBox2.Text + "'", conp);
                DataTable dtp = new DataTable();
                sdap.Fill(dtp);
                if (dtp.Rows[0][0].ToString() == "1")
                {

                    int x;
                    SqlConnection conn1 = new SqlConnection(str);
                    conn1.Open();
                    SqlCommand xcmd = new SqlCommand();
                    xcmd = conn1.CreateCommand();
                    xcmd.CommandText = ("select [Pid] from tbl_pres where [Pname] = '" + textBox2.Text + "'");
                    SqlDataReader red = xcmd.ExecuteReader();
                    red.Read();
                    x = Convert.ToInt32(red[0]);
                    SqlDataAdapter sdaz = new SqlDataAdapter("SELECT * FROM tbl_pmed WHERE [Pid] LIKE '" + x + "'", conz);
                    sdaz.Fill(dtz);
                 }
             

            }

            else if (textBox3.Text.Length > 0)
            {



                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_pres WHERE [Diag] LIKE '" + textBox3.Text + "%' ", con);
                sda.Fill(dt);

            }

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dtz;

           
            //highlite grne code
            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox1.Text || dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox2.Text)
                    {
                        dataGridView1.Rows[i].Selected = true;
                    }

                    else
                    {
                        dataGridView1.Rows[i].Selected = false;
                    }
                }
            }
            catch
            {
             
            }

        }
       
       private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0 && textBox2.Text.Length <= 0 && textBox3.Text.Length <= 0)
            {
                MessageBox.Show("Please Select ID, Name or Diagnosis");
            }
            else
            {
                if (dataGridView1.Rows.Count > 1)
                {
                   // MessageBox.Show("Record Found.");
                }
                else
                {
                    MessageBox.Show("Record Not Found.");
                
                }

            }
        }
       public void gridview()
       {

           string sql1 = "select * from tbl_pres";
           SqlConnection conn = new SqlConnection(str);
           SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
           DataSet ds = new DataSet();
           d1.Fill(ds);
           dataGridView1.DataSource = ds;
           dataGridView1.DataMember = ds.Tables[0].ToString();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           if (comboBox1.Text.Length <= 0 && textBox1.Text.Length <= 0)
           {
               MessageBox.Show("Please Select ID.");
           }
           else
           {
               string sql1 = "select * from tbl_pres where Pid = '" + comboBox1.Text + "'";
               SqlConnection c = new SqlConnection(str);
               SqlDataAdapter d1 = new SqlDataAdapter(sql1, c);
               DataSet ds = new DataSet();
               d1.Fill(ds);
               dataGridView3.DataSource = ds;
               dataGridView3.DataMember = ds.Tables[0].ToString();
               if (dataGridView3.Rows.Count > 1)
               {
                   if (comboBox1.Text.Length <= 0)
                   {
                       MessageBox.Show("Please Select ID.");
                   }
                   else
                   {
                       DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       if (dr == DialogResult.Yes)
                       {
                           SqlConnection conn = new SqlConnection(str);
                           string sql3 = "delete from tbl_pres where [Pid]= '" + comboBox1.Text + "'";
                           SqlCommand cmd3 = new SqlCommand(sql3, conn);

                           SqlConnection con = new SqlConnection(str);
                           string sql4 = "delete from tbl_pmed where [Pid]='" + comboBox1.Text + "'";
                           SqlCommand cmd4 = new SqlCommand(sql4, con);

                           try
                           {

                               conn.Open();
                               cmd3.ExecuteNonQuery();
                               MessageBox.Show("Delete Success.");
                               comboBox1.Text = null;
                               textBox1.Clear();
                               gridview();
                               textBox1.Focus();
                           }
                           catch (Exception o)
                           {

                               MessageBox.Show(o.Message);
                           }
                           try
                           {
                               con.Open();
                               cmd4.ExecuteNonQuery();
                               dataGridView2.DataSource = null;
                           }
                           catch (Exception)
                           {
                               textBox3.Clear();
                                textBox2.Clear();
                               dataGridView2.DataSource = null;
                               textBox1.Focus();
                           }
                           finally
                           {
                               con.Close();
                           }
                       }
                       else
                       {
                           //  MessageBox.Show("Record Not Found");
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
                   textBox1.Focus();
               }
           }
       }
             

    
            
    

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_pres", con);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
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
                    catch (Exception)
                    {

                        // MessageBox.Show(y.Message);
                    }

                    finally
                    {

                       
                    }

                }
                MessageBox.Show("Successfully Exported to given folder/ path");
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            display();
    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            display();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            display();
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            display();

        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            display();
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Text = textBox1.Text;
            textBox2.Text = null;
            textBox3.Text = null;
            display();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            display();
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            display();
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
                        SqlDataAdapter sdaz = new SqlDataAdapter("SELECT * FROM tbl_pmed WHERE [Pid] LIKE '" + comboBox1.Text + "'", conz);
                        sdaz.Fill(dtz);
                        

                }
                else
                {
                    MessageBox.Show("Please select a single row or cell");
                }
            }
            catch (Exception )
            {
            }
            dataGridView2.DataSource = dtz;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            View_Prescription_Details b = new View_Prescription_Details();
            b.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("All the data will be deleted. \nContinue?", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(str);
                string sql3 = "delete from tbl_pres";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);

                SqlConnection con = new SqlConnection(str);
                string sql4 = "delete from tbl_pmed";
                SqlCommand cmd4 = new SqlCommand(sql4, con);

                try
                {

                    conn.Open();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Delete Success.");
                    comboBox1.Text = null;
                    textBox1.Clear();
                    gridview();
                    textBox1.Focus();
                }
                catch (Exception o)
                {

                    MessageBox.Show(o.Message);
                }
                try
                {
                    con.Open();
                    cmd4.ExecuteNonQuery();
                    dataGridView2.DataSource = null;
                }
                catch (Exception)
                {
                    textBox3.Clear();
                    textBox2.Clear();
                    dataGridView2.DataSource = null;
                    textBox1.Focus();
                }
                finally
                {
                    con.Close();
                }
            }
                      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
}
}