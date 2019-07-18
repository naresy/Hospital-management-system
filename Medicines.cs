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

namespace Pharmacy_Management_System
{

    public partial class Medicines : Form
    {
        //int c;
        public Medicines()
        {
            InitializeComponent();
           //c=b;
        }
        public void gridview()
        {

            string sql1 = "select * from tbl_med";
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            d1.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        SqlCommand cmd = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
          
            long max;
            SqlConnection conn1 = new SqlConnection(str);
            conn1.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn1.CreateCommand();
            maxcmd.CommandText = ("select max(Sn) from tbl_med");
            SqlDataReader red = maxcmd.ExecuteReader();
            red.Read();
           

            try
            {
                max = Convert.ToInt64(red[0]);
                max++;
                textBox3.Text = max.ToString();
            }
            catch (Exception)
            {
             
                textBox3.Text = Convert.ToString(1);
            }
             
            if (textBox1.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=pusparaj-pc;Initial Catalog=Phm_db;User ID=sa;Password=naresh474210");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_med where Medicine = '" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    MessageBox.Show("The medicine \"" + (textBox1.Text) + "\" already exists.");

                }

                else
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand("insert into tbl_med([Sn],[Medicine],[Description]) values ('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')", conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine Added.");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        dataGridView1.Show();
                        gridview();
                        textBox1.Focus();

                    }
                    catch
                    {

                    }
                    finally
                    {
                        conn.Close();
                    }
                    try
                    {
                        for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox3.Text)
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
            }
           
        }
        
             

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql3 = "delete from tbl_med where [Medicine]='" + textBox1.Text + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            try
            {

                conn.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted");
                textBox1.Clear();
                textBox2.Clear();
                gridview();
            
            }
            catch (Exception)
            {
                MessageBox.Show("Medicine Not Deleted");


            }
            finally
            {
                conn.Close();

            }
            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox3.Text)
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

        private void Medicines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phm_dbDataSet83.tbl_med' table. You can move, or remove it, as needed.
            this.tbl_medTableAdapter1.Fill(this.phm_dbDataSet83.tbl_med);
            // TODO: This line of code loads data into the 'phm_dbDataSet71.tbl_med' table. You can move, or remove it, as needed.
            this.tbl_medTableAdapter.Fill(this.phm_dbDataSet71.tbl_med);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql2 = "select * from tbl_med where [Medicine]='" + textBox1.Text + "'";
            SqlDataAdapter d2 = new SqlDataAdapter(sql2, conn);
            DataTable dt1 = new DataTable();
            d2.Fill(dt1);

            try
            {

                if (dt1.Rows.Count >= 1)
                {
                    textBox3.Text = dt1.Rows[0].ItemArray[0].ToString();
                    textBox1.Text = dt1.Rows[0].ItemArray[1].ToString();
                    textBox2.Text = dt1.Rows[0].ItemArray[2].ToString();
                   
                }



                else
                {
                    MessageBox.Show("Medicine Not Found");
                    

                }
            }

            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
            }


            finally
            {
                conn.Close();
            }
            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox3.Text)
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

       

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_med set [Medicine]='" + textBox1.Text + "',[Description]='" + textBox2.Text + "' where [Sn]= '" + textBox3.Text + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Updated.");
                gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            finally
            {
              conn.Close();
            }
            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() ==textBox3.Text)
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
                  textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();      
                }
                else
                {
                    MessageBox.Show("Please select a single row or cell");
                }
            }
            catch (Exception)
            {
                // MessageBox.Show(ec.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
