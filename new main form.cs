using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class new_main_form : Form
    {
        string u,v;
        public new_main_form(string t)
        {
            InitializeComponent();
            u = t;
            label2.Text = u;
            v = u;
          
        }
   


        private void new_main_form_Load(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Logout? ", "Confirm Logout..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Show();

             
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Echocardiography_Report ew = new Echocardiography_Report(u);
            //this.Hide();
            ew.ShowDialog();
        }
        

        private void button11_Click(object sender, EventArgs e)
        {

        
            
            System.Diagnostics.Process.Start("calc.exe");
        

        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wmplayer.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            user_management uz = new user_management(u);
           
            uz.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Echocardiography_Report ec = new Echocardiography_Report(u);
           
            ec.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to Exit? \n\n We suggest you to logout first.", "Confirm Exit..............", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
              
                System.Environment.Exit(0);

              


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            backup_new mn = new backup_new();
            mn.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            change_Password c = new change_Password(u);
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Dignosis d = new Dignosis(u);
            d.ShowDialog();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Janta_medical j = new Janta_medical();
            j.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
         //MessageBox.Show("Puspa Pharmacy and Diagnostic Laboraory \n \t Dhangadhi, Kailali \n\t 091-524955", "About Us.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            About ab = new About();
            ab.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            View_Echocardiography_Report_Details vvv = new View_Echocardiography_Report_Details(u);
            vvv.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            View_Diagnosis_Details vd = new View_Diagnosis_Details();
            vd.ShowDialog();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            View_Prescription_Details vp  = new View_Prescription_Details();
            vp.ShowDialog();


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Echocardiography_Report eee = new Echocardiography_Report(u);
            eee.ShowDialog();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Dignosis d = new Dignosis(u );
            d.ShowDialog();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Janta_medical jj = new Janta_medical();
            jj.ShowDialog();


        }

        private void label13_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Generate_Echocardiography_Report hh = new Generate_Echocardiography_Report();
            hh.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Prescription_Print pp = new Prescription_Print();
            pp.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Diagnosis_Report_Print dd = new Diagnosis_Report_Print();
            dd.ShowDialog();
        }

        private void label22_Click_1(object sender, EventArgs e)
        {
            Diagnosis_Report_Print dd = new Diagnosis_Report_Print();
            dd.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //int a = 2;
            Medicines mm = new Medicines();
            mm.ShowDialog();

        }

        private void label25_Click(object sender, EventArgs e)
        {

           // int a = 2;
            Medicines mx = new Medicines();
            mx.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Billing ww = new Billing();
            ww.ShowDialog();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //int a = 2;
           // Form1 ff = new Form1();
           // ff.ShowDialog();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //int a = 2;
           // Form3 ff = new Form3();
            //ff.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
