namespace Pharmacy_Management_System
{
    partial class printbill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdata = new Pharmacy_Management_System.stdata();
            this.tbl_testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_billTableAdapter = new Pharmacy_Management_System.stdataTableAdapters.tbl_billTableAdapter();
            this.tbl_testTableAdapter = new Pharmacy_Management_System.stdataTableAdapters.tbl_testTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_billBindingSource
            // 
            this.tbl_billBindingSource.DataMember = "tbl_bill";
            this.tbl_billBindingSource.DataSource = this.stdata;
            this.tbl_billBindingSource.CurrentChanged += new System.EventHandler(this.tbl_billBindingSource_CurrentChanged);
            // 
            // stdata
            // 
            this.stdata.DataSetName = "stdata";
            this.stdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_testBindingSource
            // 
            this.tbl_testBindingSource.DataMember = "tbl_test";
            this.tbl_testBindingSource.DataSource = this.stdata;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PowderBlue;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(177, 21);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(243, 36);
            this.button7.TabIndex = 401;
            this.button7.Text = "Generate Bill";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(811, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 402;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 403;
            this.button1.Text = "Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_billTableAdapter
            // 
            this.tbl_billTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_testTableAdapter
            // 
            this.tbl_testTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.tbl_billBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pharmacy_Management_System.mainbill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1328, 609);
            this.reportViewer1.TabIndex = 404;
            // 
            // printbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 673);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Name = "printbill";
            this.Text = "printbill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.printbill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tbl_billBindingSource;
        private stdata stdata;
        private stdataTableAdapters.tbl_billTableAdapter tbl_billTableAdapter;
        private System.Windows.Forms.BindingSource tbl_testBindingSource;
        private stdataTableAdapters.tbl_testTableAdapter tbl_testTableAdapter;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}