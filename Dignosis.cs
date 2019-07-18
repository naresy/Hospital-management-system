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
    public partial class Dignosis : Form
    {
        string b;
        public Dignosis(string a)
        {
            InitializeComponent();
            b = a;
        }

         private void Dignosis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phm_dbDataSet113.tbl_diagnosis' table. You can move, or remove it, as needed.
            this.tbl_diagnosisTableAdapter3.Fill(this.phm_dbDataSet113.tbl_diagnosis);
            // TODO: This line of code loads data into the 'phm_dbDataSet112.tbl_diagnosis' table. You can move, or remove it, as needed.
            this.tbl_diagnosisTableAdapter2.Fill(this.phm_dbDataSet112.tbl_diagnosis);

            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'phm_dbDataSet27.tbl_diagnosis' table. You can move, or remove it, as needed.
          //this.tbl_diagnosisTableAdapter1.Fill(this.phm_dbDataSet27.tbl_diagnosis);
            // TODO: This line of code loads data into the 'phm_dbDataSet26.tbl_diagnosis' table. You can move, or remove it, as needed.
            //this.tbl_diagnosisTableAdapter.Fill(this.phm_dbDataSet26.tbl_diagnosis);
              
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string o = " dignosis page ko home ma double click gara kete ho";
           // new_main_form p = new new_main_form(o);
           // p.ShowDialog();
            this.Hide();

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long max;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand maxcmd = new SqlCommand();
            maxcmd = conn.CreateCommand();
            maxcmd.CommandText = ("select max(pid) from tbl_diagnosis");
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
              
                comboBox2.Text =Convert.ToString(1);
            }
            
            comboBox3.Text = null;
            maskedTextBox1.Clear();
            comboBox1.Text = null;
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox34.Text = null;
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox18.Clear();
            textBox15.Clear();
            textBox17.Clear();
            textBox21.Clear();
            textBox20.Clear();
            textBox16.Clear();
            textBox19.Clear();
            textBox22.Clear();
            textBox26.Clear();
            textBox25.Clear();
            textBox24.Clear();
            textBox23.Clear();
            textBox35.Clear();
            textBox28.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox29.Clear();
            textBox30.Clear();
            dateTimePicker1.Text = null;
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        SqlCommand cmd = new SqlCommand();
        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("insert into tbl_diagnosis([pid],[pname],[age],[sex],[address],[phone],[occ],[ht],[wt],[ac],[bmi],[pp],[past],[drug],[family],[gynae],[personnel],[social],[obs],[drugalle],[sr],[avpo],[rr],[temp],[spo2],[pr],[bilcc],[bps],[bpd],[jvp],[pb],[s1],[s2],[mm],[rs],[gia],[cns],[oth],[inv],[diag],[date]) values ('" + comboBox2.Text + "','" + comboBox3.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox34.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox12.Text + "','" + textBox11.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox18.Text + "','" + textBox15.Text + "','" + textBox17.Text + "','" + textBox21.Text + "','" + textBox20.Text + "','" + textBox16.Text + "','" + textBox19.Text + "','" + textBox22.Text + "','" + textBox26.Text + "','" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox35.Text + "','" + textBox28.Text + "','" + textBox53.Text + "','" + textBox54.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + dateTimePicker1.Text + "')", conn);
        
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();


                MessageBox.Show("User Data Inserted.");
                comboBox2.Text = null;
                comboBox3.Text = null;
                maskedTextBox1.Clear();
                comboBox1.Text = null;
                textBox4.Clear();
                textBox3.Clear();
                textBox1.Clear();
                textBox34.Text = null;
                textBox31.Clear();
                textBox32.Clear();
                textBox33.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox12.Clear();
                textBox11.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox18.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox21.Clear();
                textBox20.Clear();
                textBox16.Clear();
                textBox19.Clear();
                textBox22.Clear();
                textBox26.Clear();
                textBox25.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox35.Clear();
                textBox28.Clear();
                textBox53.Clear();
                textBox30.Clear();
                textBox54.Clear();
                textBox29.Clear();
                dateTimePicker1.Text = null;
                this.Hide();
                Dignosis d1 = new Dignosis(" ");
                d1.ShowDialog();
                
            }


            catch (Exception ez)
            {
                MessageBox.Show(ez.Message);
            }

            finally
            {
                conn.Close();
               
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
                string sql2 = "select * from tbl_diagnosis where [pid]='" + comboBox2.Text + "'";
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
                        textBox4.Text = dt1.Rows[0].ItemArray[4].ToString();
                        textBox3.Text = dt1.Rows[0].ItemArray[5].ToString();
                        textBox1.Text = dt1.Rows[0].ItemArray[6].ToString();
                        textBox34.Text = dt1.Rows[0].ItemArray[7].ToString();
                        textBox31.Text = dt1.Rows[0].ItemArray[8].ToString();
                        textBox32.Text = dt1.Rows[0].ItemArray[9].ToString();
                        textBox33.Text = dt1.Rows[0].ItemArray[10].ToString();
                        textBox2.Text = dt1.Rows[0].ItemArray[11].ToString();
                        textBox5.Text = dt1.Rows[0].ItemArray[12].ToString();
                        textBox6.Text = dt1.Rows[0].ItemArray[13].ToString();
                        textBox7.Text = dt1.Rows[0].ItemArray[14].ToString();
                        textBox12.Text = dt1.Rows[0].ItemArray[15].ToString();
                        textBox11.Text = dt1.Rows[0].ItemArray[16].ToString();
                        textBox8.Text = dt1.Rows[0].ItemArray[17].ToString();
                        textBox9.Text = dt1.Rows[0].ItemArray[18].ToString();
                        textBox10.Text = dt1.Rows[0].ItemArray[19].ToString();
                        textBox13.Text = dt1.Rows[0].ItemArray[20].ToString();
                        textBox14.Text = dt1.Rows[0].ItemArray[21].ToString();
                        textBox18.Text = dt1.Rows[0].ItemArray[22].ToString();
                        textBox15.Text = dt1.Rows[0].ItemArray[23].ToString();
                        textBox17.Text = dt1.Rows[0].ItemArray[24].ToString();
                        textBox21.Text = dt1.Rows[0].ItemArray[25].ToString();
                        textBox20.Text = dt1.Rows[0].ItemArray[26].ToString();
                        textBox16.Text = dt1.Rows[0].ItemArray[27].ToString();
                        textBox19.Text = dt1.Rows[0].ItemArray[28].ToString();
                        textBox22.Text = dt1.Rows[0].ItemArray[29].ToString();
                        textBox26.Text = dt1.Rows[0].ItemArray[30].ToString();
                        textBox25.Text = dt1.Rows[0].ItemArray[31].ToString();
                        textBox24.Text = dt1.Rows[0].ItemArray[32].ToString();
                        textBox23.Text = dt1.Rows[0].ItemArray[33].ToString();
                        textBox35.Text = dt1.Rows[0].ItemArray[34].ToString();
                        textBox28.Text = dt1.Rows[0].ItemArray[35].ToString();
                        textBox53.Text = dt1.Rows[0].ItemArray[36].ToString();
                        textBox54.Text = dt1.Rows[0].ItemArray[37].ToString();
                        textBox29.Text = dt1.Rows[0].ItemArray[38].ToString();
                        textBox30.Text = dt1.Rows[0].ItemArray[39].ToString();
                        dateTimePicker1.Text = dt1.Rows[0].ItemArray[40].ToString();

                    }


                    else
                    {
                        MessageBox.Show("Record Not Found.");
                        comboBox2.Text = null;
                        comboBox3.Text = null;

                    }
                }

                catch (Exception ex)
                {
                    // MessageBox.Show("Search Successful...");
                    MessageBox.Show(ex.Message);
                }


                finally
                {
                    conn.Close();



                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Length <= 0)
            {

                MessageBox.Show("Please select ID.");
            }

            else
            {

                SqlConnection cond = new SqlConnection(str);
                string sql2 = "select * from tbl_diagnosis where [pid]='" + comboBox2.Text + "'";
                SqlDataAdapter d2 = new SqlDataAdapter(sql2, cond);
                DataTable dt1 = new DataTable();
                d2.Fill(dt1);

                try
                {

                    if (dt1.Rows.Count >= 1)
                    {

                        DialogResult dr = MessageBox.Show("Do you really want to Delete? ", "Confirm Delete..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            SqlConnection conn = new SqlConnection(str);
                            string sql3 = "delete from tbl_diagnosis where [pid]='" + comboBox2.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(sql3, conn);
                            try
                            {

                                conn.Open();
                                cmd3.ExecuteNonQuery();
                                MessageBox.Show("Delete Success.");


                                comboBox2.Text = null;
                                comboBox3.Text = null;
                                maskedTextBox1.Clear();
                                comboBox1.Text = null;
                                textBox4.Clear();
                                textBox3.Clear();
                                textBox1.Clear();
                                textBox34.Text = null;
                                textBox31.Clear();
                                textBox32.Clear();
                                textBox33.Clear();
                                textBox2.Clear();
                                textBox5.Clear();
                                textBox6.Clear();
                                textBox7.Clear();
                                textBox12.Clear();
                                textBox11.Clear();
                                textBox8.Clear();
                                textBox9.Clear();
                                textBox10.Clear();
                                textBox13.Clear();
                                textBox14.Clear();
                                textBox18.Clear();
                                textBox15.Clear();
                                textBox17.Clear();
                                textBox21.Clear();
                                textBox20.Clear();
                                textBox16.Clear();
                                textBox19.Clear();
                                textBox22.Clear();
                                textBox26.Clear();
                                textBox25.Clear();
                                textBox24.Clear();
                                textBox23.Clear();
                                textBox35.Clear();
                                textBox28.Clear();
                                textBox53.Clear();
                                textBox54.Clear();
                                textBox29.Clear();
                                textBox30.Clear();
                                dateTimePicker1.Text = null;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);


                            }
                            finally
                            {
                                conn.Close();
                                // MessageBox.Show("Record Not Deleted");

                            }
                        }
                        else
                        {

                            comboBox2.Text = null;
                            comboBox3.Text = null;
                            maskedTextBox1.Clear();
                            comboBox1.Text = null;
                            textBox4.Clear();
                            textBox3.Clear();
                            textBox1.Clear();
                            textBox34.Text = null;
                            textBox31.Clear();
                            textBox32.Clear();
                            textBox33.Clear();
                            textBox2.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox12.Clear();
                            textBox11.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            textBox10.Clear();
                            textBox13.Clear();
                            textBox14.Clear();
                            textBox18.Clear();
                            textBox15.Clear();
                            textBox17.Clear();
                            textBox21.Clear();
                            textBox20.Clear();
                            textBox16.Clear();
                            textBox19.Clear();
                            textBox22.Clear();
                            textBox26.Clear();
                            textBox25.Clear();
                            textBox24.Clear();
                            textBox23.Clear();
                            textBox35.Clear();
                            textBox28.Clear();
                            textBox53.Clear();
                            textBox54.Clear();
                            textBox29.Clear();
                            textBox30.Clear();
                            dateTimePicker1.Text = null;
                        }//else

                    }//uf

                    else
                    {
                        MessageBox.Show("Record Not Found.");
                    }
                }
                catch
                {

                }
            }
        }
                

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);

            cmd = new SqlCommand("update tbl_diagnosis set [pname]='" + comboBox3.Text + "',[age]='" + maskedTextBox1.Text + "',[sex]='" + comboBox1.Text + "',[address]='" + textBox4.Text + "',[phone]='" + textBox4.Text + "',[occ]='" + textBox1.Text + "',[ht]='" + textBox34.Text + "',[wt]='" + textBox31.Text + "',[ac]='" + textBox32.Text + "',[bmi]='" + textBox33.Text + "',[pp]='" + textBox2.Text + "',[past]='" + textBox5.Text + "',[drug]='" + textBox6.Text + "',[family]='" + textBox7.Text + "',[gynae]='" + textBox12.Text + "',[personnel]='" + textBox11.Text + "',[social]='" + textBox8.Text + "',[obs]='" + textBox9.Text + "',[drugalle]='" + textBox10.Text + "',[sr]='" + textBox13.Text + "',[avpo]='" + textBox14.Text + "',[rr]='" + textBox18.Text + "',[temp]='" + textBox15.Text + "',[spo2]='" + textBox17.Text + "',[pr]='" + textBox21.Text + "',[bilcc]='" + textBox20.Text + "',[bps]='" + textBox16.Text + "',[bpd]='" + textBox19.Text + "',[jvp]='" + textBox22.Text + "',[pb]='" + textBox26.Text + "',[s1]='" + textBox25.Text + "',[s2]='" + textBox24.Text + "',[mm]='" + textBox23.Text + "',[rs]='" + textBox35.Text + "',[gia]='" + textBox28.Text + "',[cns]='" + textBox53.Text + "',[oth]='" + textBox54.Text + "',[inv]='" + textBox29.Text + "',[diag]='" + textBox30.Text + "',[date]='" + dateTimePicker1.Text + "' where pid = '"+comboBox2.Text+"'", conn);
            try
            {

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Is Updated.");
                comboBox2.Text = null;
                comboBox3.Text = null;
                maskedTextBox1.Clear();
                comboBox1.Text = null;
                textBox4.Clear();
                textBox3.Clear();
                textBox1.Clear();
                textBox34.Text = null;
                textBox31.Clear();
                textBox32.Clear();
                textBox33.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox12.Clear();
                textBox11.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox18.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox21.Clear();
                textBox20.Clear();
                textBox16.Clear();
                textBox19.Clear();
                textBox22.Clear();
                textBox26.Clear();
                textBox25.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox35.Clear();
                textBox28.Clear();
                textBox53.Clear();
                textBox54.Clear();
                textBox29.Clear();
                textBox30.Clear();
                dateTimePicker1.Text = null;

                this.Hide();
                Dignosis d1 = new Dignosis(" ");
                d1.ShowDialog();
                

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



        private void button9_Click(object sender, EventArgs e)
        {
            View_Diagnosis_Details v = new View_Diagnosis_Details();
            v.ShowDialog();
            //this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            comboBox3.Text = null;
            maskedTextBox1.Clear();
            comboBox1.Text = null;
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox34.Text = null;
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox18.Clear();
            textBox15.Clear();
            textBox17.Clear();
            textBox21.Clear();
            textBox20.Clear();
            textBox16.Clear();
            textBox19.Clear();
            textBox22.Clear();
            textBox26.Clear();
            textBox25.Clear();
            textBox24.Clear();
            textBox23.Clear();
            textBox35.Clear();
            textBox28.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox29.Clear();
            textBox30.Clear();
            dateTimePicker1.Text = null;
        
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            ///comboBox3.Text = null;
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
           /// comboBox2.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Diagnosis_Report_Print rep = new Diagnosis_Report_Print();
            rep.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Diagnosis_Report_Print dd = new Diagnosis_Report_Print();
            dd.ShowDialog();
        }

        

        private void button9_Click_1(object sender, EventArgs e)
        {
            View_Diagnosis_Details vv = new View_Diagnosis_Details();
            vv.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dignosis eee = new Dignosis(b);
            eee.ShowDialog();
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
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
