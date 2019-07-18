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
using System.IO;
using System.Management;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace Pharmacy_Management_System
{
    public partial class Billing : Form
    {
        
        public int b = 0;
        public Billing()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            comboBox12.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox13.Text = null;
            maskedTextBox1.Clear();
            comboBox1.Text = null;
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phm_dbDataSet128.tbl_test' table. You can move, or remove it, as needed.
           // this.tbl_testTableAdapter.Fill(this.phm_dbDataSet128.tbl_test);
            comboBox2.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        //SqlConnection conn = new SqlConnection(str);
        public void gridview()
        {

            string sql1 = "select * from tbl_test where Bid = '" + comboBox12.Text + "'";
            SqlConnection conn1 = new SqlConnection(str);
            SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn1);
            DataSet ds = new DataSet();
            d1.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox9.Text = comboBox12.Text;
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_bill set [Pname]='" + comboBox13.Text + "',[Age]='" + maskedTextBox1.Text + "',[Sex]='" + comboBox1.Text + "',[Phone]='" + textBox4.Text + "',[Address]='" + textBox1.Text + "',[Regfee]='" + textBox3.Text + "',[Dcharge]='" + textBox5.Text + "',[Echarge]='" + textBox6.Text + "',[Total]='" + textBox7.Text + "',[Date]='" + dateTimePicker1.Text + "' where [Bid]='" + comboBox12.Text + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Bill Data Updated");
                comboBox12.Text = null;
                comboBox2.Text = null;
                comboBox3.Text = null;
                comboBox13.Text = null;
                maskedTextBox1.Clear();
                comboBox1.Text = null;
                textBox4.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                dataGridView1.DataSource = null;
               // this.Close();
               // Billing jjj = new Billing();
               // jjj.ShowDialog();
                //  this.Close();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);


            }


            finally
            {
                conn.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox13.Text = null;
            comboBox12.Text = null;
            maskedTextBox1.Text = null;
            comboBox1.Text = null;
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();

            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();

            dateTimePicker1.ResetText();
            dataGridView1.DataSource = null;
            comboBox3.Text = null;

            comboBox2.Text = null;

            comboBox12.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox9.Text = comboBox12.Text;
            comboBox13.Text = null;
            if (comboBox12.Text.Length <= 0)
            {
                MessageBox.Show("Please Select Bill ID.");
            }

            else
            {
                SqlConnection conn = new SqlConnection(str);
                string sql2 = "select * from tbl_bill where [Bid]='" + comboBox12.Text + "'";
                SqlDataAdapter d2 = new SqlDataAdapter(sql2, conn);
                DataTable dt1 = new DataTable();
                d2.Fill(dt1);
                // gridview();
                try
                {

                    if (dt1.Rows.Count >= 1)
                    {
                        comboBox12.Text = dt1.Rows[0].ItemArray[0].ToString();
                        comboBox13.Text = dt1.Rows[0].ItemArray[1].ToString();
                        maskedTextBox1.Text = dt1.Rows[0].ItemArray[2].ToString();
                        comboBox1.Text = dt1.Rows[0].ItemArray[3].ToString();
                        textBox4.Text = dt1.Rows[0].ItemArray[4].ToString();
                        textBox1.Text = dt1.Rows[0].ItemArray[5].ToString();
                        textBox3.Text = dt1.Rows[0].ItemArray[6].ToString();
                        textBox5.Text = dt1.Rows[0].ItemArray[7].ToString();
                        textBox6.Text = dt1.Rows[0].ItemArray[8].ToString();
                        textBox7.Text = dt1.Rows[0].ItemArray[9].ToString();

                        gridview();

                    }
                    else
                    {
                        MessageBox.Show("Record not found");
                        // comboBox12.Text = null;
                        comboBox12.Text = null;

                    }
                }

                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }


                finally
                {
                    conn.Close();



                }
            }
        }

      
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_test set [Bid]='" + comboBox12.Text + "',[Tname]='" + comboBox2.Text + "',[Amt]='" + comboBox3.Text + "' where [Sn]= '" + textBox2.Text + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Test data Updated");
                comboBox3.Text = null;
                comboBox2.Text = null;

                gridview();

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data. Check the data and try again.");
            }


            finally
            {
                conn.Close();

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    comboBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    comboBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Please select a single row or cell");
                }
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(str);
                string sql3 = "delete from tbl_test where [Bid]='" + comboBox12.Text + "'and [Tname]='" + comboBox2.Text + "' ";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                try
                {
                    conn.Open();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Delete Success");
                    // c = c - 1;
                    gridview();
                    comboBox3.Text = null;

                    comboBox2.Text = null;

                }
                catch (Exception)
                {
                    MessageBox.Show("Medicine Not Deleted/ Not Found");
                    gridview();
                    comboBox3.Text = null;

                    comboBox2.Text = null;
                }
                finally
                {
                    conn.Close();


                }


            }
        }

      
            //String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        SqlCommand cmd = new SqlCommand();
        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            long max;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn.CreateCommand();
            maxcmd.CommandText = ("select max(Bid) from tbl_bill");
            SqlDataReader red = maxcmd.ExecuteReader();
            red.Read();
            b = 0;

            try
            {
                max = Convert.ToInt64(red[0]);
                max++;
                comboBox12.Text = max.ToString();
            }
            catch (Exception)
            {
                // MessageBox.Show(ez.Message);
                comboBox12.Text = Convert.ToString(1);
            }

            comboBox13.Text = null;
            maskedTextBox1.Clear();
            comboBox1.Text = null;
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
        

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int max;
            SqlConnection conn1 = new SqlConnection(str);
            conn1.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn1.CreateCommand();
            maxcmd.CommandText = ("select max(Sn) from tbl_test");
            SqlDataReader red = maxcmd.ExecuteReader();
            red.Read();
            b = 0;

            try
            {
                max = Convert.ToInt32(red[0]);
                max++;
                textBox2.Text = max.ToString();
            }
            catch (Exception)
            {
                textBox2.Text = Convert.ToString(1);
            }



            SqlConnection conn = new SqlConnection(str);
            if (comboBox12.Text.Length > 0 && comboBox2.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=pusparaj-pc;Initial Catalog=Phm_db;User ID=sa;Password=naresh474210");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_test where Bid = '" + comboBox12.Text + "' and Tname = '" + comboBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    MessageBox.Show("The test name \"" + (comboBox2.Text) + "\" already exists.");

                }

                else
                {

                    if (b == 0)
                    {
                        SqlCommand cmd = new SqlCommand("insert into tbl_bill([Bid],[Pname],[Age],[Sex],[Phone],[Address],[Regfee],[Dcharge],[Echarge],[Total],[Date]) values ('" + comboBox12.Text + "','" + comboBox13.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "')", conn);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            // comboBox2.Text = null;
                            // comboBox3.Text = null;

                            //  MessageBox.Show("Patient Data Saved insert medicine  wala");
                        }

                        catch (Exception)
                        {

                        }


                        finally
                        {
                            conn.Close();

                        }
                        SqlCommand cmd1 = new SqlCommand("insert into tbl_test([Sn],[Bid],[Tname],[Amt]) values ('" + textBox2.Text + "','" + comboBox12.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')", conn);
                        try
                        {
                            conn.Open();
                            cmd1.ExecuteNonQuery();
                           // c = c + 1;
                            //textBox9.Text = Convert.ToString(c);

                            // MessageBox.Show("medicine saved click on next to add new medicine");
                        }
                        catch (Exception ev)
                        {
                            MessageBox.Show(ev.Message);
                            MessageBox.Show("bhayena");
                        }
                        b++;
                    }
                    else if (b == 1)
                    {


                        SqlCommand cmd1 = new SqlCommand("insert into tbl_test([Bid],[Tname],[Amt]) values ('" + comboBox12.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')", conn);
                        try
                        {
                            conn.Open();
                            cmd1.ExecuteNonQuery();
                           // c = c + 1;
                           // textBox9.Text = Convert.ToString(c);
                            //MessageBox.Show("Patient Data Saved a ko value 1 bhaye paxi");
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Data .Please check the data and try again.");
                    }

                }
            }

            gridview();
            comboBox2.Focus();
        }
        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox12.Text.Length <= 0)
            {
                MessageBox.Show("Please select Bill id");
            }
            else
            {
                SqlConnection conq = new SqlConnection(str);
                string sql2 = "select * from tbl_bill where [Bid]='" + comboBox12.Text + "'";
                SqlDataAdapter d2 = new SqlDataAdapter(sql2, conq);
                DataTable dt1 = new DataTable();
                d2.Fill(dt1);




                if (dt1.Rows.Count >= 1)
                {
                    DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(str);
                        SqlConnection con = new SqlConnection(str);
                        string sql3 = "delete from tbl_bill where [Bid]='" + comboBox12.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(sql3, conn);
                        try
                        {
                            conn.Open();
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Delete Success");
                            this.Close();
                            Billing jjj = new Billing();
                            jjj.ShowDialog();
                            // this.Close();
                            comboBox12.Focus();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Record Not Deleted/ Not Found");
                            this.Close();
                            Billing jjj = new Billing();
                            jjj.ShowDialog();
                            // this.Close();
                        }
                        finally
                        {
                            conn.Close();


                        }
                        string sql4 = "delete from tbl_test where [Bid]='" + comboBox12.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(sql4, con);
                        try
                        {

                            con.Open();
                            cmd4.ExecuteNonQuery();
                            // MessageBox.Show("Delete Success");
                            comboBox13.Text = null;
                            comboBox12.Text = null;
                            maskedTextBox1.Text = null;
                            comboBox1.Text = null;
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox1.Clear();

                            textBox6.Clear();
                            textBox5.Clear();
                            textBox7.Clear();

                            dateTimePicker1.ResetText();
                            dataGridView1.DataSource = null;
                            comboBox3.Text = null;

                            comboBox2.Text = null;

                            comboBox12.Focus();



                        }
                        catch (Exception)
                        {
                            // MessageBox.Show("Record Not Deleted");
                            comboBox13.Text = null;
                            comboBox12.Text = null;
                            maskedTextBox1.Text = null;
                            comboBox1.Text = null;
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox1.Clear();

                            textBox6.Clear();
                            textBox5.Clear();
                            textBox7.Clear();

                            dateTimePicker1.ResetText();
                            dataGridView1.DataSource = null;
                            comboBox3.Text = null;

                            comboBox2.Text = null;

                            comboBox12.Focus();
                        }
                        finally
                        {
                            con.Close();


                        }
                    }
                    else
                    {
                        comboBox12.Text = null;
                        comboBox12.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found.");

                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text = comboBox12.Text;
            SqlConnection conn = new SqlConnection(str);
            if (b == 0)
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_bill([Bid],[Pname],[Age],[Sex],[Phone],[Address],[Regfee],[Dcharge],[Echarge],[Total],[Date]) values ('" + comboBox12.Text + "','" + comboBox13.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Data Inserted.");
                    comboBox12.Text = null;
                    comboBox2.Text = null;
                    comboBox3.Text = null;
                    comboBox13.Text = null;
                    maskedTextBox1.Clear();
                    comboBox1.Text = null;
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    dataGridView1.DataSource = null;
                   // this.Close();
                   // Billing jjj = new Billing();
                   // jjj.ShowDialog();

                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message);
                    comboBox12.Focus();
                }
            }

            else
            {
                SqlCommand cmd = new SqlCommand("update tbl_bill set [Pname]='" + comboBox13.Text + "',[Age]='" + maskedTextBox1.Text + "',[Sex]='" + comboBox1.Text + "',[Phone]='" + textBox4.Text + "',[Address]='" + textBox1.Text + "',[Regfee]='" + textBox3.Text + "',[Dcharge]='" + textBox5.Text + "',[Echarge]='" + textBox6.Text + "',[Total]='" + textBox7.Text + "',[Date]='" + dateTimePicker1.Text + "' where [Bid]='" + comboBox12.Text + "'", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Data Inserted.");
                    comboBox12.Text = null;
                    comboBox2.Text = null;
                    comboBox3.Text = null;
                    comboBox13.Text = null;
                    maskedTextBox1.Clear();
                    comboBox1.Text = null;
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    dataGridView1.DataSource = null;
                    //this.Close();
                   // Billing jjj = new Billing();
                   // jjj.ShowDialog();
                    // this.Close();
                }

                catch (Exception)
                {
                    //MessageBox.Show(Ex.Message);

                    // MessageBox.Show("Record already exists. Give different Login Name and Password");
                }


                finally
                {
                    conn.Close();


                }
            }
            //textBox9.Text = comboBox12.Text;
            //this.Hide();
            //printbill pp = new printbill(comboBox12.Text);
           // pp.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbltestBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            this.Hide();
            Billing bb = new Billing();
            bb.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblbillBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tblbillBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tblbillBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbltestBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tblbillBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbltestBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox9.Text = comboBox12.Text;
            Double sum = 0;
            dataGridView1.AllowUserToAddRows = false;

            try
            {
                if (textBox5.Text.Length < 1)
                {
                    textBox5.Text = Convert.ToString(0);
                }

                if (textBox3.Text.Length < 1)
                {
                    textBox3.Text = Convert.ToString(0);
                }

                if (textBox6.Text.Length < 1)
                {
                    textBox6.Text = Convert.ToString(0);
                }

                if (textBox8.Text.Length < 1)
                {
                    textBox8.Text = Convert.ToString(0);
                }


                if (dataGridView1.Rows.Count >= 1)
                {

                    for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                    {

                        sum = sum + Double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }


                    textBox8.Text = sum.ToString();

                }

                Double total = sum + Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(total);
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                MessageBox.Show("kaam garena");
            }


            finally
            {


            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String p = textBox9.Text;
            printbill pp = new printbill(p);
            pp.ShowDialog();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
            {

                e.Handled = false;



            }
            else
            {

                e.Handled = true;



            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
            {

                e.Handled = false;



            }
            else
            {

                e.Handled = true;



            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46)
            {

                e.Handled = false;



            }
            else
            {

                e.Handled = true;



            }
        }

        private void comboBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32)
            {

                e.Handled = false;


            }
            else
            {

                e.Handled = true;



            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {

                e.Handled = false;



            }
            else
            {

                e.Handled = true;



            }
        }

       
    }
}
