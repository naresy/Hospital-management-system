using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace Pharmacy_Management_System
{
    public partial class backup_new : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionstring = "";
        public backup_new()
        {
            InitializeComponent();
            comboBox4.Text = "pusparaj-pc";
            comboBox5.Text = "naresh474210";
            comboBox6.Text = "sa";
            comboBox1.Text = "Phm_db";
            label8.Visible = false;
        }

        private void backup_new_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            button6.Enabled = false;
            try
            {
                connectionstring = "Data Source = '" + comboBox4.Text + "'; User Id = '" + comboBox6.Text + "'; Password='" + comboBox5.Text + "'";
                conn = new SqlConnection(connectionstring);
                conn.Open();
                sql = "EXEC sp_databases";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());

                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                comboBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connectionstring = "Data Source = '" + comboBox4.Text + "'; User Id = '"+comboBox6.Text+"'; Password='"+comboBox5.Text+"'";
                conn = new SqlConnection(connectionstring);
                conn.Open();
                sql = "EXEC sp_databases";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                   
                }
                reader.Dispose();
                conn.Close();
                conn.Dispose();
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                comboBox1.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            button6.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text.Length < 1)
            {
                MessageBox.Show("Please Browse where to Backup.");

            }
            else
            {
               
                    label8.Visible = true;

                    DialogResult dr = MessageBox.Show("This may take few seconds or minutes depending on your Database.\nDo you want to Backup?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            if (comboBox1.Text.CompareTo("") == 0)
                            {

                                MessageBox.Show("Please select database.");
                                return;
                            }
                            conn = new SqlConnection(connectionstring);
                            conn.Open();
                            sql = "BACKUP DATABASE " + comboBox1.Text + " TO DISK= '" + comboBox2.Text + "\\" + comboBox1.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                            command = new SqlCommand(sql, conn);
                            command.ExecuteNonQuery();
                            conn.Close();
                            conn.Dispose();
                            MessageBox.Show("Backup Successful.");
                            label8.Visible = false;
                        }
                        catch (Exception )
                        {
                            MessageBox.Show("System do not allow to create backup in C:\\ Drive.\nPlease Select another Directory.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Backup Cancelled.");
                    }
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = dlg.SelectedPath;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BACKUP Files (*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                comboBox3.Text = dlg.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text.Length < 1)
            {
                MessageBox.Show("Please Browse The Backup File.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("This may take few seconds or minutes depending on your Database.\nDo you want to Restore?", "Restore Database..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    label8.Visible = true;
                    try
                    {
                        if (comboBox1.Text.CompareTo("") == 0)
                        {
                            MessageBox.Show("Please select database.");
                            return;
                        }
                        conn = new SqlConnection(connectionstring);
                        conn.Open();
                        // sql = "Alter Database " + comboBox1.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                        sql = "Restore Database " + comboBox1.Text + " FROM DISK = '" + comboBox3.Text + "' WITH RECOVERY;";
                        command = new SqlCommand(sql, conn);

                        Server localServer = new Server();
                        localServer.KillAllProcesses("Phm_db");
                        localServer.KillDatabase("Phm_db");
                        command.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();
                        MessageBox.Show("Restore Successful.");
                        label8.Visible = false;
                    }
                    catch (Exception ww)
                    {
                        MessageBox.Show(ww.Message);
                    }
                }
                else
                {

                    MessageBox.Show("Restore Cancelled.");
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
