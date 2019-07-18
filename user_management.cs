using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Drawing.Imaging;


namespace Pharmacy_Management_System
{
    public partial class user_management : Form
    {

        //SqlDataReader dr;
        //SqlParameter picture;
        SqlCommand cmd = new SqlCommand();
        string b;
        int a=1;
        public user_management(string a)
        {
            InitializeComponent();
            b = a;
            dataGridView1.DataSource = null;
        }

        public void gridview()
        {
            
            string sql1 = "select * from tbl_um";
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter d1 = new SqlDataAdapter(sql1, conn);
            DataSet ds = new DataSet();
            d1.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void user_management_Load(object sender, EventArgs e)
        {
            gridview();
            // TODO: This line of code loads data into the 'phm_dbDataSet44.tbl_um' table. You can move, or remove it, as needed.
            this.tbl_umTableAdapter2.Fill(this.phm_dbDataSet44.tbl_um);
            // TODO: This line of code loads data into the 'phm_dbDataSet43.tbl_um' table. You can move, or remove it, as needed.
            this.tbl_umTableAdapter1.Fill(this.phm_dbDataSet43.tbl_um);
            // TODO: This line of code loads data into the 'phm_dbDataSet7.tbl_um' table. You can move, or remove it, as needed.
            //this.tbl_umTableAdapter.Fill(this.phm_dbDataSet7.tbl_um);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtTelephone.Clear();
            txtFullName.Clear();
            txtLoginName.Clear();
            txtPassword.Clear();
            textBox1.Clear();
            textBox2.Clear();
            pictureBox2.Image = null;
           
        }
        String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();


        private void button1_Click(object sender, EventArgs e)
        {


            //table ma insert garne code
            if (txtLoginName.Text.Length > 0 && txtPassword.Text.Length > 0)
            {

                SqlConnection conn = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand("insert into tbl_um([Lname],[Fname],[Password],[Email],[Tel],[Address],[picture]) values ('" + txtLoginName.Text + "','" + txtFullName.Text + "','" + txtPassword.Text + "','" + textBox1.Text + "','" + txtTelephone.Text + "','" + textBox2.Text + "', @picture)", conn);

                if (pictureBox2.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] a = ms.GetBuffer();
                    ms.Close();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@picture", a);


                }

                else
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                    byte[] a = ms.GetBuffer();
                    ms.Close();
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@picture", a);


                }






                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("User Data Inserted.");
                    gridview();






                }




                catch (Exception)
                {
                    // MessageBox.Show(Ex.Message);

                    MessageBox.Show("Record already exists. Give different Login Name and Password.");
                }


                finally
                {
                    conn.Close();

                }



                //img sv grne .jpg ma

                if (string.IsNullOrEmpty(txtLoginName.Text) && string.IsNullOrEmpty(txtPassword.Text))
                {
                    
                    return;
                }
                else
                {
                    try
                    {

                        pictureBox2.Image.Save(Application.StartupPath + "\\Images\\" + txtLoginName.Text + ".jpg", ImageFormat.Jpeg);


                    }
                    catch (Exception)
                    {

                        // MessageBox.Show(ex.ToString());
                    }
                }
                txtTelephone.Clear();
                txtFullName.Clear();
                txtLoginName.Clear();
                txtPassword.Clear();
                textBox1.Clear();
                textBox2.Clear();
                pictureBox2.Image = null;

            }
            else
            {

                MessageBox.Show(" Please Enter Login Name and password.");
            
            }
        }

        
        

        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("No content available to remove!", "No Content.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            try
            {

                OpenFileDialog f = new OpenFileDialog();

                f.InitialDirectory = "C:/Picture/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(f.FileName);
                    pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                   // label1.Text = f.SafeFileName.ToString();


                }
            }
            catch
            {

            }

        }
        private void savepicture()
        {

            
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            SqlConnection conn = new SqlConnection(str);

            cmd = new SqlCommand("update tbl_um set Lname='" + txtLoginName.Text + "',Fname='" + txtFullName.Text + "', Password='" + txtPassword.Text + "',Email='" + textBox1.Text + "', Tel='" + txtTelephone.Text + "', Address='" + textBox2.Text + "',picture=@picture  where  Lname='" + txtLoginName.Text + "'", conn);

            if (pictureBox2.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@picture", a);



            }

                try
                {

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Success.");
                    gridview();
                    txtTelephone.Clear();
                    txtFullName.Clear();
                    txtLoginName.Clear();
                    txtPassword.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    pictureBox2.Image = null;
                
                }
                catch (Exception )
                {
                    MessageBox.Show("Update failed.");
                   // MessageBox.Show(a.Message);
                }
                finally
                {
                    conn.Close();

                }

            }


        private void button3_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(str);
                string sql2 = "select * from tbl_um where [Lname]='" + txtLoginName.Text + "'";

                SqlDataAdapter d2 = new SqlDataAdapter(sql2, conn);
                DataTable dt1 = new DataTable();
                DataSet ds = new DataSet();
                d2.Fill(dt1);
                d2.Fill(ds);

                if (dt1.Rows.Count >= 1)
                {
                    txtFullName.Text = dt1.Rows[0].ItemArray[1].ToString();
                    txtPassword.Text = dt1.Rows[0].ItemArray[2].ToString();
                    textBox1.Text = dt1.Rows[0].ItemArray[3].ToString();
                    txtTelephone.Text = dt1.Rows[0].ItemArray[4].ToString();
                    textBox2.Text = dt1.Rows[0].ItemArray[5].ToString();

                    //highlite grne code
                    try
                    {
                        for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtLoginName.Text)
                            {
                                dataGridView1.Rows[i].Selected = true;
                            }

                            else
                            {
                                dataGridView1.Rows[i].Selected = false;
                            }
                        }
                        gridview();
                    }

                    catch
                    {

                    }

                }
                else
                {
                    MessageBox.Show("There is no user of this Login Name. \nPlease re-check the Login Name.");
                  //  pictureBox2.Image = null;
                    txtTelephone.Clear();
                    txtFullName.Clear();
                    txtPassword.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    a = 10;
                }

                try
                {
                    byte[] ap = (byte[])(ds.Tables[0].Rows[0]["picture"]);
                    MemoryStream ms = new MemoryStream(ap);
                    pictureBox2.Image = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    pictureBox2.Image = null;
                    if (a != 10)
                    {
                        MessageBox.Show("There is no image for this user. Please update the image of the user to view next time.");
                    }
                    a = 1;
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please Select Login Name.");
            
            }
        }
     
    

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text.Length > 0)
            {
                SqlConnection conn = new SqlConnection(str);
                string sql3 = "delete from tbl_um where [Lname]='" + txtLoginName.Text + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                try
                {

                    conn.Open();
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Delete Success.");

                    gridview();
                    txtTelephone.Clear();
                    txtFullName.Clear();
                    txtLoginName.Clear();
                    txtPassword.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    pictureBox2.Image = null;


                }
                catch (Exception)
                {
                    MessageBox.Show("Record Not Deleted.");


                }
                finally
                {
                    conn.Close();

                }
            }
            else
            {
                MessageBox.Show("Please Select Login Name. ");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtTelephone.Clear();
            txtFullName.Clear();
            txtLoginName.Clear();
            txtPassword.Clear();
            textBox1.Clear();
            textBox2.Clear();
            pictureBox2.Image = null;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    txtLoginName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtFullName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtPassword.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtTelephone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a single row or cell.");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}