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
    public partial class Echocardiography_Report : Form
    {
       
        string b;
        public Echocardiography_Report(string a)
        {
            InitializeComponent();
            
            b = a;
            textBox42.Text = b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Echocardiography_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phm_dbDataSet127.tbl_echo' table. You can move, or remove it, as needed.
            this.tbl_echoTableAdapter6.Fill(this.phm_dbDataSet127.tbl_echo);
            // TODO: This line of code loads data into the 'phm_dbDataSet111.tbl_echo' table. You can move, or remove it, as needed.
            this.tbl_echoTableAdapter5.Fill(this.phm_dbDataSet111.tbl_echo);
             comboBox2.Text = null;
            comboBox3.Text = null;
            textBox3.Clear();
            maskedTextBox1.Text = "";
            textBox4.Clear();
            comboBox1.Text = null;
            dateTimePicker1.Text = "";
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox13.Clear();
            textBox10.Clear();
            textBox14.Clear();
            textBox11.Clear();
            textBox15.Clear();
            textBox12.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox18.Clear();
            textBox22.Clear();
            textBox28.Clear();
            textBox27.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox24.Clear();
            textBox23.Clear();
            textBox29.Clear();
            textBox21.Clear();
            textBox33.Clear();
            textBox32.Clear();
            textBox31.Clear();
            textBox30.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox47.Clear();
            textBox46.Clear();
          
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            
            comboBox2.Focus();
        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        SqlCommand cmd = new SqlCommand();
        private void button3_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(str);

             cmd = new SqlCommand("insert into tbl_echo([ID],[Name],[Age],[Sex],[Address],[Reffby],[CF],[Ecg],[CXR],[LA],[AO],[RA],[RV],[IVSd],[IVSs],[LVIDd],[LVIDs],[LVPWd],[LVPWs],[LVEF],[APML],[EVEG],[AVAG],[EAratio],[MVS],[MR],[Mort],[PVt],[PGt],[TR],[Mora],[PVa],[PGa],[AR],[Morp],[PVp],[PGp],[PR],[IAS],[IVS],[WM],[Pericardium],[IM],[Vegetation],[AF],[Summ],[Diag],[Preby],[Date]) values ('" + comboBox2.Text + "','" + comboBox3.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox47.Text + "','" + textBox46.Text + "','" + textBox9.Text + "','" + textBox13.Text + "','" + textBox10.Text + "','" + textBox14.Text + "','" + textBox11.Text + "','" + textBox15.Text + "','" + textBox12.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox18.Text + "','" + textBox22.Text + "','" + textBox28.Text + "','" + textBox27.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox29.Text + "','" + textBox21.Text + "','" + textBox33.Text + "','" + textBox32.Text + "','" + textBox31.Text + "','" + textBox30.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "','" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + textBox44.Text + "','" + textBox43.Text + "','" + textBox42.Text + "','" + dateTimePicker1.Text + "')", conn);
            try
            {

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Is Inserted.");

                comboBox2.Text = null;
                comboBox3.Text = null;
                textBox3.Clear();
                maskedTextBox1.Text = "";
                textBox4.Clear();
                comboBox1.Text = null;
                dateTimePicker1.Text = "";
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox14.Clear();
                textBox11.Clear();
                textBox15.Clear();
                textBox12.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox18.Clear();
                textBox22.Clear();
                textBox28.Clear();
                textBox27.Clear();
                textBox25.Clear();
                textBox26.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox29.Clear();
                textBox21.Clear();
                textBox33.Clear();
                textBox32.Clear();
                textBox31.Clear();
                textBox30.Clear();
                textBox34.Clear();
                textBox35.Clear();
                textBox36.Clear();
                textBox37.Clear();
                textBox38.Clear();
                textBox39.Clear();
                textBox40.Clear();
                textBox43.Clear();
                textBox44.Clear();
                textBox47.Clear();
                textBox46.Clear();
                comboBox2.Focus();
                this.Hide();

                Echocardiography_Report j1 = new Echocardiography_Report(" ");
                j1.ShowDialog();
                
            }


            catch (Exception )
            {
                //MessageBox.Show(ed.Message);
            // MessageBox.Show("Invalid Data.\n Please Check the data and try again. ");
            }

            finally
            {
            
            
            conn.Close();

            
            }

           


        }

        private void lineShape10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Generate_Echocardiography_Report nn = new Generate_Echocardiography_Report();
            nn.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text.Length <= 0)
            {
                MessageBox.Show("Please select ID.");
            }
            else
            {
                SqlConnection conq = new SqlConnection(str);
                string sql2 = "select * from tbl_echo where [ID]='" + comboBox2.Text + "'";
                SqlDataAdapter d2 = new SqlDataAdapter(sql2, conq);
                DataTable dt1 = new DataTable();
                d2.Fill(dt1);
                    if (dt1.Rows.Count >= 1)
                    {
                        DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            SqlConnection conn = new SqlConnection(str);
                            string sql3 = "delete from tbl_echo where [ID]='" + comboBox2.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(sql3, conn);
                            try
                            {

                                conn.Open();
                                cmd3.ExecuteNonQuery();
                                MessageBox.Show("Delete Success.");
                                comboBox2.Text = null;
                                comboBox3.Text = null;
                                textBox3.Clear();
                                maskedTextBox1.Text = "";
                                textBox4.Clear();
                                comboBox1.Text = null;
                                dateTimePicker1.Text = "";
                                textBox2.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox7.Clear();
                                textBox8.Clear();
                                textBox9.Clear();
                                textBox13.Clear();
                                textBox10.Clear();
                                textBox14.Clear();
                                textBox11.Clear();
                                textBox15.Clear();
                                textBox12.Clear();
                                textBox16.Clear();
                                textBox17.Clear();
                                textBox19.Clear();
                                textBox20.Clear();
                                textBox18.Clear();
                                textBox22.Clear();
                                textBox28.Clear();
                                textBox27.Clear();
                                textBox25.Clear();
                                textBox26.Clear();
                                textBox24.Clear();
                                textBox23.Clear();
                                textBox29.Clear();
                                textBox21.Clear();
                                textBox33.Clear();
                                textBox32.Clear();
                                textBox31.Clear();
                                textBox30.Clear();
                                textBox34.Clear();
                                textBox35.Clear();
                                textBox36.Clear();
                                textBox37.Clear();
                                textBox38.Clear();
                                textBox39.Clear();
                                textBox40.Clear();
                                textBox43.Clear();
                                textBox42.Clear();
                                textBox44.Clear();
                                textBox47.Clear();
                                textBox46.Clear();


                            }
                            catch (Exception)
                            {
                                //MessageBox.Show(ex.Message);


                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        else
                        {
                            comboBox2.Text = null;
                            comboBox3.Text = null;
                            textBox3.Clear();
                            maskedTextBox1.Text = "";
                            textBox4.Clear();
                            comboBox1.Text = null;
                            dateTimePicker1.Text = "";
                            textBox2.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            textBox13.Clear();
                            textBox10.Clear();
                            textBox14.Clear();
                            textBox11.Clear();
                            textBox15.Clear();
                            textBox12.Clear();
                            textBox16.Clear();
                            textBox17.Clear();
                            textBox19.Clear();
                            textBox20.Clear();
                            textBox18.Clear();
                            textBox22.Clear();
                            textBox28.Clear();
                            textBox27.Clear();
                            textBox25.Clear();
                            textBox26.Clear();
                            textBox24.Clear();
                            textBox23.Clear();
                            textBox29.Clear();
                            textBox21.Clear();
                            textBox33.Clear();
                            textBox32.Clear();
                            textBox31.Clear();
                            textBox30.Clear();
                            textBox34.Clear();
                            textBox35.Clear();
                            textBox36.Clear();
                            textBox37.Clear();
                            textBox38.Clear();
                            textBox39.Clear();
                            textBox40.Clear();
                            textBox43.Clear();
                            textBox42.Clear();
                            textBox44.Clear();
                            textBox47.Clear();
                            textBox46.Clear();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Record Not Found.");

                    }
                }

          

         }
   



        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Text = null;
            if (comboBox2.Text.Length <= 0 || comboBox3.Text.Length >= 1 || comboBox3.Text == null)
            {
                MessageBox.Show("Please Select Patient ID.");
            }

            else
            {
                SqlConnection conn = new SqlConnection(str);
                string sql2 = "select * from tbl_echo where [ID]='" + comboBox2.Text + "'";
                SqlDataAdapter d2 = new SqlDataAdapter(sql2, conn);
                DataTable dt1 = new DataTable();
                d2.Fill(dt1);

                try
                {

                    if (dt1.Rows.Count >= 1)
                    {
                        comboBox2.Text = dt1.Rows[0].ItemArray[0].ToString();
                        comboBox3.Text = dt1.Rows[0].ItemArray[1].ToString();
                        maskedTextBox1.Text = dt1.Rows[0].ItemArray[2].ToString();
                        comboBox1.Text = dt1.Rows[0].ItemArray[3].ToString();
                        textBox3.Text = dt1.Rows[0].ItemArray[4].ToString();
                        textBox4.Text = dt1.Rows[0].ItemArray[5].ToString();
                        textBox2.Text = dt1.Rows[0].ItemArray[6].ToString();
                        textBox5.Text = dt1.Rows[0].ItemArray[7].ToString();
                        textBox6.Text = dt1.Rows[0].ItemArray[8].ToString();
                        textBox7.Text = dt1.Rows[0].ItemArray[9].ToString();
                        textBox8.Text = dt1.Rows[0].ItemArray[10].ToString();
                        textBox47.Text = dt1.Rows[0].ItemArray[11].ToString();
                        textBox46.Text = dt1.Rows[0].ItemArray[12].ToString();
                        textBox9.Text = dt1.Rows[0].ItemArray[13].ToString();
                        textBox13.Text = dt1.Rows[0].ItemArray[14].ToString();
                        textBox10.Text = dt1.Rows[0].ItemArray[15].ToString();
                        textBox14.Text = dt1.Rows[0].ItemArray[16].ToString();
                        textBox11.Text = dt1.Rows[0].ItemArray[17].ToString();
                        textBox15.Text = dt1.Rows[0].ItemArray[18].ToString();
                        textBox12.Text = dt1.Rows[0].ItemArray[19].ToString();
                        textBox16.Text = dt1.Rows[0].ItemArray[20].ToString();
                        textBox17.Text = dt1.Rows[0].ItemArray[21].ToString();
                        textBox19.Text = dt1.Rows[0].ItemArray[22].ToString();
                        textBox20.Text = dt1.Rows[0].ItemArray[23].ToString();
                        textBox18.Text = dt1.Rows[0].ItemArray[24].ToString();
                        textBox22.Text = dt1.Rows[0].ItemArray[25].ToString();
                        textBox28.Text = dt1.Rows[0].ItemArray[26].ToString();
                        textBox27.Text = dt1.Rows[0].ItemArray[27].ToString();
                        textBox25.Text = dt1.Rows[0].ItemArray[28].ToString();
                        textBox26.Text = dt1.Rows[0].ItemArray[29].ToString();
                        textBox24.Text = dt1.Rows[0].ItemArray[30].ToString();
                        textBox23.Text = dt1.Rows[0].ItemArray[31].ToString();
                        textBox29.Text = dt1.Rows[0].ItemArray[32].ToString();
                        textBox21.Text = dt1.Rows[0].ItemArray[33].ToString();
                        textBox33.Text = dt1.Rows[0].ItemArray[34].ToString();
                        textBox32.Text = dt1.Rows[0].ItemArray[35].ToString();
                        textBox31.Text = dt1.Rows[0].ItemArray[36].ToString();
                        textBox30.Text = dt1.Rows[0].ItemArray[37].ToString();
                        textBox34.Text = dt1.Rows[0].ItemArray[38].ToString();
                        textBox35.Text = dt1.Rows[0].ItemArray[39].ToString();
                        textBox36.Text = dt1.Rows[0].ItemArray[40].ToString();
                        textBox37.Text = dt1.Rows[0].ItemArray[41].ToString();
                        textBox38.Text = dt1.Rows[0].ItemArray[42].ToString();
                        textBox39.Text = dt1.Rows[0].ItemArray[43].ToString();
                        textBox40.Text = dt1.Rows[0].ItemArray[44].ToString();
                        textBox44.Text = dt1.Rows[0].ItemArray[45].ToString();
                        textBox43.Text = dt1.Rows[0].ItemArray[46].ToString();
                        textBox42.Text = dt1.Rows[0].ItemArray[47].ToString();
                        dateTimePicker1.Text = dt1.Rows[0].ItemArray[48].ToString();

                    }



                    else
                    {
                        MessageBox.Show("Record not found.");
                        comboBox3.Text = null;
                        comboBox2.Text = null;

                    }
                }

                catch (Exception)
                {
                    // MessageBox.Show("Search Successful...");
                   // MessageBox.Show(ex.Message);
                }


                finally
                {
                    conn.Close();
                }

            }
        }

        internal void Invoke()
        {
            throw new NotImplementedException();
        }

        internal void Invoke(string p)
        {
            throw new NotImplementedException();
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            long max;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn.CreateCommand();
            maxcmd.CommandText = ("select max(ID) from tbl_echo");
            SqlDataReader red = maxcmd.ExecuteReader();
            red.Read();
            try
            {
                max = Convert.ToInt64(red[0]);
                max++;
                comboBox2.Text = max.ToString();
            }
            catch
            {
                comboBox2.Text = Convert.ToString(1);
            }
            comboBox3.Text = null;
            textBox3.Clear();
            maskedTextBox1.Text = "";
            textBox4.Clear();
            comboBox1.Text = null;
            dateTimePicker1.Text = "";
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox13.Clear();
            textBox10.Clear();
            textBox14.Clear();
            textBox11.Clear();
            textBox15.Clear();
            textBox12.Clear();
            textBox16.Text = "Normal";
            textBox17.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox18.Text = "Normal";
            textBox22.Clear();
            textBox28.Text = "Normal";
            textBox27.Clear();
            textBox25.Clear();
            textBox26.Text = "Nill";
            textBox24.Text = "Normal";
            textBox23.Clear();
            textBox29.Clear();
            textBox21.Text = "Nill";
            textBox33.Text = "Normal";
            textBox32.Clear();
            textBox31.Clear();
            textBox30.Text = "Nill";
            textBox34.Text = "Intact";
            textBox35.Text = "Intact";
            textBox36.Text = "Normal";
            textBox37.Text = "No Pericardial Effusion";
            textBox38.Text = "Not Seen";
            textBox39.Text = "Not Seen";
            textBox40.Text = "NAD";
            textBox43.Text = "Grossly Normal Echocardiography";
            textBox44.Clear();
            textBox47.Clear();
            textBox46.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string v = textBox42.Text;
            View_Echocardiography_Report_Details vz = new View_Echocardiography_Report_Details(v);
            vz.ShowDialog();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            comboBox3.Text = null;
            textBox3.Clear();
            maskedTextBox1.Text = "";
            textBox4.Clear();
            comboBox1.Text = null;
            dateTimePicker1.Text = "";
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox13.Clear();
            textBox10.Clear();
            textBox14.Clear();
            textBox11.Clear();
            textBox15.Clear();
            textBox12.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox18.Clear();
            textBox22.Clear();
            textBox28.Clear();
            textBox27.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox24.Clear();
            textBox23.Clear();
            textBox29.Clear();
            textBox21.Clear();
            textBox33.Clear();
            textBox32.Clear();
            textBox31.Clear();
            textBox30.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox47.Clear();
            textBox46.Clear();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(str);

            cmd = new SqlCommand("update tbl_echo set [Name]='" + comboBox3.Text + "',[Age]='" + maskedTextBox1.Text + "',[Sex]='" + comboBox1.Text + "',[Address]='" + textBox3.Text + "',[Reffby]='" + textBox4.Text + "',[CF]='" + textBox2.Text + "',[Ecg]='" + textBox5.Text + "',[CXR]='" + textBox6.Text + "',[LA]='" + textBox7.Text + "',[AO]='" + textBox8.Text + "',[RA]='" + textBox47.Text + "',[RV]='" + textBox46.Text + "',[IVSd]='" + textBox9.Text + "',[IVSs]='" + textBox13.Text + "',[LVIDd]='" + textBox10.Text + "',[LVIDs]='" + textBox14.Text + "',[LVPWd]='" + textBox11.Text + "',[LVPWs]='" + textBox15.Text + "',[LVEF]='" + textBox12.Text + "',[APML]='" + textBox16.Text + "',[EVEG]='" + textBox17.Text + "',[AVAG]='" + textBox19.Text + "',[EAratio]='" + textBox20.Text + "',[MVS]='" + textBox18.Text + "',[MR]='" + textBox22.Text + "',[Mort]='" + textBox28.Text + "',[PVt]='" + textBox27.Text + "',[PGt]='" + textBox25.Text + "',[TR]='" + textBox26.Text + "',[Mora]='" + textBox24.Text + "',[PVa]='" + textBox23.Text + "',[PGa]='" + textBox29.Text + "',[AR]='" + textBox21.Text + "',[Morp]='" + textBox33.Text + "',[PVp]='" + textBox32.Text + "',[PGp]='" + textBox31.Text + "',[PR]='" + textBox30.Text + "',[IAS]='" + textBox34.Text + "',[IVS]='" + textBox35.Text + "',[WM]='" + textBox36.Text + "',[Pericardium]='" + textBox37.Text + "',[IM]='" + textBox38.Text + "',[Vegetation]='" + textBox39.Text + "',[AF]='" + textBox40.Text + "',[Summ]='" + textBox44.Text + "',[Diag]='" + textBox43.Text + "',[Preby]='" + textBox42.Text + "',[Date]='" + dateTimePicker1.Text + "' where ID ='"+comboBox2.Text+"'", conn);
            try
            {

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Updated.");
                comboBox2.Text = null;
                comboBox3.Text = null;
                textBox3.Clear();
                maskedTextBox1.Text = "";
                textBox4.Clear();
                comboBox1.Text = null;
                dateTimePicker1.Text = "";
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox14.Clear();
                textBox11.Clear();
                textBox15.Clear();
                textBox12.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox18.Clear();
                textBox22.Clear();
                textBox28.Clear();
                textBox27.Clear();
                textBox25.Clear();
                textBox26.Clear();
                textBox24.Clear();
                textBox23.Clear();

                textBox29.Clear();
                textBox21.Clear();
                textBox33.Clear();
                textBox32.Clear();
                textBox31.Clear();
                textBox30.Clear();
                textBox34.Clear();
                textBox35.Clear();
                textBox36.Clear();
                textBox37.Clear();
                textBox38.Clear();
                textBox39.Clear();
                textBox40.Clear();
                textBox43.Clear();
                textBox42.Clear();
                textBox44.Clear();
                textBox47.Clear();
                textBox46.Clear();
                comboBox2.Focus();
                this.Hide();

                Echocardiography_Report j1 = new Echocardiography_Report(" ");
                j1.ShowDialog();

            }
            catch (Exception ex)
            {
                                MessageBox.Show(ex.Message);
            }

            finally
            {
               conn.Close();
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Echocardiography_Report eee = new Echocardiography_Report(b);
            eee.ShowDialog();
       
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        }
    }

