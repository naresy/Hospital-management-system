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
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
namespace Pharmacy_Management_System
{
    public partial class Janta_medical : Form
    {
        public int a = 0;
        
        public Janta_medical()
        {

            InitializeComponent();
           
            comboBox12.Text = null;
            comboBox13.Text = null;
            maskedTextBox1.Text = null;
            comboBox1.Text = null;
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            comboBox7.Text=null;
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            dateTimePicker1.ResetText();
            dataGridView1.DataSource = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox2.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox3.SelectedIndex = -1;
        }






        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox13.Text = null;
            if (comboBox12.Text.Length <= 0 || comboBox13.Text.Length >= 1 || comboBox13.Text==null)
            {
                MessageBox.Show("Please Select Patient ID.");
            }
           
            else
            {
                SqlConnection conn = new SqlConnection(str);
                string sql2 = "select * from tbl_pres where [Pid]='" + comboBox12.Text + "'";
                SqlDataAdapter d2 = new SqlDataAdapter(sql2, conn);
                DataTable dt1 = new DataTable();
                d2.Fill(dt1);
                gridview();
                try
                {

                    if (dt1.Rows.Count >= 1)
                    {
                        comboBox12.Text = dt1.Rows[0].ItemArray[0].ToString();
                        comboBox13.Text = dt1.Rows[0].ItemArray[1].ToString();
                        maskedTextBox1.Text = dt1.Rows[0].ItemArray[2].ToString();
                        comboBox1.Text = dt1.Rows[0].ItemArray[3].ToString();
                        textBox3.Text = dt1.Rows[0].ItemArray[4].ToString();
                        textBox4.Text = dt1.Rows[0].ItemArray[5].ToString();
                        textBox1.Text = dt1.Rows[0].ItemArray[6].ToString();
                        textBox2.Text = dt1.Rows[0].ItemArray[7].ToString();
                        textBox6.Text = dt1.Rows[0].ItemArray[8].ToString();
                        textBox5.Text = dt1.Rows[0].ItemArray[9].ToString();
                        textBox7.Text = dt1.Rows[0].ItemArray[10].ToString();
                        comboBox7.Text = dt1.Rows[0].ItemArray[11].ToString();
                        textBox14.Text = dt1.Rows[0].ItemArray[12].ToString();
                        textBox15.Text = dt1.Rows[0].ItemArray[13].ToString();
                        textBox16.Text = dt1.Rows[0].ItemArray[14].ToString();
                        dateTimePicker1.Text = dt1.Rows[0].ItemArray[15].ToString();
                        gridview();
                        comboBox3.Text = null;
                        comboBox4.Text = null;
                        comboBox2.Text = null;
                        comboBox5.Text = null;
                        comboBox6.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Record not found");
                        // comboBox12.Text = null;
                        comboBox13.Text = null;

                    }
                }

                catch (Exception)
                {
                }


                finally
                {
                    conn.Close();



                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        SqlCommand cmd = new SqlCommand();


        private void button1_Click(object sender, EventArgs e)
        {
            long max;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn.CreateCommand();
            maxcmd.CommandText = ("select max(Pid) from tbl_pres");
            SqlDataReader red = maxcmd.ExecuteReader();
            red.Read();
            a = 0;

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
            maskedTextBox1.Text = null;
            comboBox1.Text = null;
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            comboBox7.Text=null;
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            dateTimePicker1.ResetText();
            dataGridView1.DataSource = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox2.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox12.Text.Length <= 0)
            {
                MessageBox.Show("Please select id");
            }
            else
            {
                SqlConnection conq = new SqlConnection(str);
                string sql2 = "select * from tbl_pres where [Pid]='" + comboBox12.Text + "'";
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
                        string sql3 = "delete from tbl_pres where [Pid]='" + comboBox12.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(sql3, conn);
                        try
                        {
                            conn.Open();
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Delete Success");
                            Janta_medical jjj = new Janta_medical();
                            jjj.ShowDialog();
                            this.Close();
                            comboBox12.Focus();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Record Not Deleted/ Not Found");
                            Janta_medical jjj = new Janta_medical();
                            jjj.ShowDialog();
                            this.Close();
                        }
                        finally
                        {
                            conn.Close();


                        }
                        string sql4 = "delete from tbl_pmed where [Pid]='" + comboBox12.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(sql4, con);
                        try
                        {

                            con.Open();
                            cmd4.ExecuteNonQuery();
                            // MessageBox.Show("Delete Success");
                            comboBox13.Text = null;
                            maskedTextBox1.Text = null;
                            comboBox1.Text = null;
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox6.Clear();
                            textBox5.Clear();
                            textBox7.Clear();
                            comboBox7.Text = null;
                            textBox14.Clear();
                            textBox15.Clear();
                            textBox16.Clear();
                            dateTimePicker1.ResetText();
                            dataGridView1.DataSource = null;
                            comboBox3.Text = null;
                            comboBox4.Text = null;
                            comboBox2.Text = null;
                            comboBox5.Text = null;
                            comboBox6.Text = null;
                            comboBox12.Focus();



                        }
                        catch (Exception)
                        {
                            // MessageBox.Show("Record Not Deleted");
                            comboBox13.Text = null;
                            maskedTextBox1.Text = null;
                            comboBox1.Text = null;
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox6.Clear();
                            textBox5.Clear();
                            textBox7.Clear();
                            comboBox7.Text = null;
                            textBox14.Clear();
                            textBox15.Clear();
                            textBox16.Clear();
                            dateTimePicker1.ResetText();
                            dataGridView1.DataSource = null;
                            comboBox3.Text = null;
                            comboBox4.Text = null;
                            comboBox2.Text = null;
                            comboBox5.Text = null;
                            comboBox6.Text = null;
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Janta_medical_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phm_dbDataSet109.tbl_med' table. You can move, or remove it, as needed.
            this.tbl_medTableAdapter2.Fill(this.phm_dbDataSet109.tbl_med);
            // TODO: This line of code loads data into the 'phm_dbDataSet108.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter4.Fill(this.phm_dbDataSet108.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet107.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter3.Fill(this.phm_dbDataSet107.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet89.tbl_pres' table. You can move, or remove it, as needed.
            this.tbl_presTableAdapter2.Fill(this.phm_dbDataSet89.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet84.tbl_med' table. You can move, or remove it, as needed.
            this.tbl_medTableAdapter1.Fill(this.phm_dbDataSet84.tbl_med);
            // TODO: This line of code loads data into the 'phm_dbDataSet81.tbl_pmed' table. You can move, or remove it, as needed.
            //this.tbl_pmedTableAdapter1.Fill(this.phm_dbDataSet81.tbl_pmed);
            // TODO: This line of code loads data into the 'phm_dbDataSet80.tbl_pres' table. You can move, or remove it, as needed.
          //  this.tbl_presTableAdapter1.Fill(this.phm_dbDataSet80.tbl_pres);
            // TODO: This line of code loads data into the 'phm_dbDataSet79.tbl_pres' table. You can move, or remove it, as needed.
          //  this.tbl_presTableAdapter.Fill(this.phm_dbDataSet79.tbl_pres);
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox3.Text = null;
            // TODO: This line of code loads data into the 'phm_dbDataSet75.tbl_med' table. You can move, or remove it, as needed.
           // this.tbl_medTableAdapter.Fill(this.phm_dbDataSet75.tbl_med);
            // TODO: This line of code loads data into the 'phm_dbDataSet74.tbl_pmed' table. You can move, or remove it, as needed.
            this.tbl_pmedTableAdapter.Fill(this.phm_dbDataSet74.tbl_pmed);
            // TODO: This line of code loads data into the 'phm_dbDataSet30.doc_prescription' table. You can move, or remove it, as needed.

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            comboBox12.Text= null;
            comboBox13.Text = null;
            maskedTextBox1.Text = null;
            comboBox1.Text = null;
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            comboBox7.Text=null;
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            dateTimePicker1.ResetText();
            dataGridView1.DataSource = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox2.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;





        }
        public void gridview()
        {
           
            string sql1 = "select * from tbl_pmed where Pid = '" + comboBox12.Text + "'";
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            d1.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_pres set [Pname]='" + comboBox13.Text + "',[Age]='" + maskedTextBox1.Text + "',[Sex]='" + comboBox1.Text + "',[Tel]='" + textBox3.Text + "',[Address]='" + textBox4.Text + "',[Wt]='" + textBox1.Text + "',[Ht]='" + textBox2.Text + "',[LMP]='" + textBox6.Text + "',[Lact]='" + textBox5.Text + "',[Drugall]='" + textBox7.Text + "',[Diag]='" + comboBox7.Text + "',[Instruct]='" + textBox14.Text + "',[Disby]='" + textBox15.Text + "',[Counsby]='" + textBox16.Text + "',[Date]='" + dateTimePicker1.Text + "' where [Pid]='" + comboBox12.Text + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Data Updated");
                comboBox13.Text = null;
                maskedTextBox1.Text = null;
                comboBox1.Text = null;
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox6.Clear();
                textBox5.Clear();
                textBox7.Clear();
                comboBox7.Text=null;
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                dateTimePicker1.ResetText();
                dataGridView1.DataSource = null;
                comboBox3.Text = null;
                comboBox4.Text = null;
                comboBox2.Text = null;
                comboBox5.Text = null;
                comboBox6.Text = null;
                this.Hide();
                Janta_medical jjj = new Janta_medical();
                jjj.ShowDialog();
                
            }

            catch (Exception)
            {
                // MessageBox.Show(Ex.Message);

                // MessageBox.Show("Record already exists. Give different Login Name and Password");
            }


            finally
            {
                conn.Close();

            }


        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            View_Prescription_Details t = new View_Prescription_Details();
            t.ShowDialog();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            {
                if (a == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert into tbl_pres([Pid],[Pname],[Age],[Sex],[Tel],[Address],[Wt],[Ht],[LMP],[Lact],[Drugall],[Diag],[Instruct],[Disby],[Counsby],[Date]) values ('" + comboBox12.Text + "','" + comboBox13.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + comboBox7.Text + "','" + textBox14.Text + "', '" + textBox15.Text + "','" + textBox16.Text + "','" + dateTimePicker1.Text + "')", conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Patient Data Saved next wala");
                    }

                    catch (Exception)
                    {
                        // MessageBox.Show(Ex.Message);

                        // MessageBox.Show("Record already exists. Give different Login Name and Password");
                    }


                    finally
                    {
                        conn.Close();

                    }
                    SqlCommand cmd1 = new SqlCommand("insert into tbl_pmed([Pid],[Medicine],[Dose],[Duration],[Unit],[Remarks]) values ('" + comboBox12.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox2.Text + "','" + comboBox6.Text + "')", conn);
                    try
                    {
                        conn.Open();
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("medicine saved click on next to add new medicine");
                    }
                    catch
                    {
                    }
                    a++;
                }
                else if (a == 1)
                {


                    SqlCommand cmd1 = new SqlCommand("insert into tbl_pmed([Pid],[Medicine],[Dose],[Duration],[Unit],[Remarks]) values ('" + comboBox12.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox2.Text + "','" + comboBox6.Text + "')", conn);
                    try
                    {
                        conn.Open();
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Patient Data Saved a ko value 1 bhaye paxi");
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("An error occured.");
                }
                gridview();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            if (a == 0)
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_pres([Pid],[Pname],[Age],[Sex],[Tel],[Address],[Wt],[Ht],[LMP],[Lact],[Drugall],[Diag],[Instruct],[Disby],[Counsby],[Date]) values ('" + comboBox12.Text + "','" + comboBox13.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + comboBox7.Text + "','" + textBox14.Text + "', '" + textBox15.Text + "','" + textBox16.Text + "','" + dateTimePicker1.Text + "')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Data Saved next wala");
                    comboBox13.Text = null;
                    maskedTextBox1.Text = null;
                    comboBox1.Text = null;
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox7.Clear();
                    comboBox7.Text=null;
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox16.Clear();
                    dateTimePicker1.ResetText();
                    dataGridView1.DataSource = null;
                    comboBox3.Text = null;
                    comboBox4.Text = null;
                    comboBox2.Text = null;
                    comboBox5.Text = null;
                    comboBox6.Text = null;
                    Janta_medical jjj = new Janta_medical();
                    jjj.ShowDialog();
                    this.Close();
                }

                catch (Exception)
                {
                     MessageBox.Show("The Patient ID \""+(comboBox12.Text)+"\" already exists. Please enter a new one.");
                     comboBox12.Focus();

                    // MessageBox.Show("Record already exists. Give different Login Name and Password");
                }


                finally
                {
                    conn.Close();

                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update tbl_pres set [Pname]='" + comboBox13.Text + "',[Age]='" + maskedTextBox1.Text + "',[Sex]='" + comboBox1.Text + "',[Tel]='" + textBox3.Text + "',[Address]='" + textBox4.Text + "',[Wt]='" + textBox1.Text + "',[Ht]='" + textBox2.Text + "',[LMP]='" + textBox6.Text + "',[Lact]='" + textBox5.Text + "',[Drugall]='" + textBox7.Text + "',[Diag]='" + comboBox7.Text + "',[Instruct]='" + textBox14.Text + "',[Disby]='" + textBox15.Text + "',[Counsby]='" + textBox16.Text + "',[Date]='" + dateTimePicker1.Text + "' where [Pid]='" + comboBox12.Text + "'", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Data Saved");
                    comboBox13.Text = null;
                    maskedTextBox1.Text = null;
                    comboBox1.Text = null;
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox7.Clear();
                    comboBox7.Text=null;
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox16.Clear();
                    dateTimePicker1.ResetText();
                    dataGridView1.DataSource = null;
                    comboBox3.Text = null;
                    comboBox4.Text = null;
                    comboBox2.Text = null;
                    comboBox5.Text = null;
                    comboBox6.Text = null;
                    this.Hide();
                    Janta_medical jjj = new Janta_medical();
                    jjj.ShowDialog();
                 
                }

                catch (Exception )
                {
                    //MessageBox.Show(Ex.Message);

                    // MessageBox.Show("Record already exists. Give different Login Name and Password");
                }


                finally
                {
                    conn.Close();


                }
            }

           
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            int max;
            SqlConnection conn1 = new SqlConnection(str);
            conn1.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn1.CreateCommand();
            maxcmd.CommandText = ("select max(Sn) from tbl_pmed");
            SqlDataReader red = maxcmd.ExecuteReader();
            red.Read();
            a = 0;

            try
            {
                max = Convert.ToInt32(red[0]);
                max++;
                 textBox9.Text = max.ToString();
            }
            catch (Exception)
            {
              textBox9.Text= Convert.ToString(1);
            }


            SqlConnection conn = new SqlConnection(str);
            if (comboBox12.Text.Length > 0 && comboBox3.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=pusparaj-pc;Initial Catalog=Phm_db;User ID=sa;Password=naresh474210");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from tbl_pmed where Pid = '" + comboBox12.Text + "' and Medicine = '" + comboBox3.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    MessageBox.Show("The medicine \""+ (comboBox3.Text) + "\" already exists.");

                }

                else
                {

                    if (a == 0)
                    {
                        SqlCommand cmd = new SqlCommand("insert into tbl_pres([Pid],[Pname],[Age],[Sex],[Tel],[Address],[Wt],[Ht],[LMP],[Lact],[Drugall],[Diag],[Instruct],[Disby],[Counsby],[Date]) values ('" + comboBox12.Text + "','" + comboBox13.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + comboBox7.Text + "','" + textBox14.Text + "', '" + textBox15.Text + "','" + textBox16.Text + "','" + dateTimePicker1.Text + "')", conn);
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();

                          //  MessageBox.Show("Patient Data Saved insert medicine  wala");
                        }

                        catch (Exception)
                        {

                        }


                        finally
                        {
                            conn.Close();

                        }
                        SqlCommand cmd1 = new SqlCommand("insert into tbl_pmed([Sn],[Pid],[Medicine],[Dose],[Duration],[Unit],[Remarks]) values ('" + textBox9.Text + "','" + comboBox12.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox2.Text + "','" + comboBox6.Text + "')", conn);
                        try
                        {
                            conn.Open();
                            cmd1.ExecuteNonQuery();

                           // MessageBox.Show("medicine saved click on next to add new medicine");
                        }
                        catch (Exception ev)
                        {
                            MessageBox.Show(ev.Message);
                        }
                        a++;
                    }
                    else if (a == 1)
                    {


                        SqlCommand cmd1 = new SqlCommand("insert into tbl_pmed([Pid],[Medicine],[Dose],[Duration],[Unit],[Remarks]) values ('" + comboBox12.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox2.Text + "','" + comboBox6.Text + "')", conn);
                        try
                        {
                            conn.Open();
                            cmd1.ExecuteNonQuery();

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
                comboBox3.Focus();

                // ya dekhi pusparaj le 
                int max1;
                SqlConnection conn11 = new SqlConnection(str);
                conn11.Open();
                SqlCommand max1cmd = new SqlCommand();
                max1cmd = conn11.CreateCommand();
                max1cmd.CommandText = ("select max(Sn) from tbl_med");
                SqlDataReader red1 = max1cmd.ExecuteReader();
                red1.Read();
                string s;
                try
                {
                    max1 = Convert.ToInt32(red1[0]);
                    max1++;
                    s = max1.ToString();
                }
                catch (Exception)
                {
                    //khadai xa
                    s = Convert.ToString(1);
                }
                if (comboBox3.Text.Length > 0)
                {
                    SqlConnection conx = new SqlConnection(@"Data Source=pusparaj-pc;Initial Catalog=Phm_db;User ID=sa;Password=naresh474210");
                    SqlDataAdapter sdax = new SqlDataAdapter("select count(*) from tbl_med where Medicine = '" + comboBox3.Text + "'", conx);
                    DataTable dtx = new DataTable();
                    sdax.Fill(dtx);
                    if (dtx.Rows[0][0].ToString() == "1")
                    {

                     //   MessageBox.Show("The medicine \"" + (comboBox3.Text) + "\" already exists. in med table ");

                    }

                    else
                    {
                        SqlConnection co = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("insert into tbl_med([Sn],[Medicine],[Description]) values ('" + s + "','" + comboBox3.Text + "','" + "-" + "')", co);
                        try
                        {
                            co.Open();
                            cmd.ExecuteNonQuery();
                          //  MessageBox.Show("Medicine Added. ta med tbl");
                           }
                        catch
                        {

                        }
                        finally
                        {
                            co.Close();
                        }
                        
                    }
                }
         
            
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //int x = 1;
            Medicines nm = new Medicines();
            nm.ShowDialog();
            //this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs f)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    comboBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    comboBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    comboBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    comboBox6.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    textBox9.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a single row or cell");
                }
            }
            catch (Exception )
            {
            }
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            
                DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(str);
                    string sql3 = "delete from tbl_pmed where [Pid]='" + comboBox12.Text + "'and [Medicine]='" + comboBox3.Text + "' ";
                    SqlCommand cmd3 = new SqlCommand(sql3, conn);
                    try
                    {
                        conn.Open();
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Delete Success");
                        gridview();
                        comboBox3.Text = null;
                        comboBox4.Text = null;
                        comboBox2.Text = null;
                        comboBox5.Text = null;
                        comboBox6.Text = null;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Medicine Not Deleted/ Not Found");
                        gridview();
                        comboBox3.Text = null;
                        comboBox4.Text = null;
                        comboBox2.Text = null;
                        comboBox5.Text = null;
                        comboBox6.Text = null;
                    }
                    finally
                    {
                        conn.Close();


                    }
                
               
            }
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_pmed set [Pid]='" + comboBox12.Text + "',[Medicine]='" + comboBox3.Text + "',[Dose]='" + comboBox4.Text + "',[Duration]='" + comboBox5.Text + "',[Unit]='" + comboBox2.Text + "',[Remarks]='" + comboBox6.Text + "' where [Sn]= '"+textBox9.Text+"'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Medicine Updated");
                comboBox3.Text = null;
                comboBox4.Text = null;
                comboBox2.Text = null;
                comboBox5.Text = null;
                comboBox6.Text = null;
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

        private void comboBox12_TextChanged(object sender, EventArgs e)
        {
            comboBox13.Text = null;
            maskedTextBox1.Text = null;
            comboBox1.Text = null;
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            comboBox7.Text=null;
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            dateTimePicker1.ResetText();
            dataGridView1.DataSource = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox2.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;

        }

       

        private void button14_Click_1(object sender, EventArgs e)
        {
            Prescription_Print pp = new Prescription_Print();
            pp.ShowDialog();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            
            View_Prescription_Details m = new View_Prescription_Details();
            m.ShowDialog();


        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Janta_medical f = new Janta_medical();
            f.ShowDialog();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}


