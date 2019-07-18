namespace Pharmacy_Management_System
{
    partial class Medicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicines));
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phm_dbDataSet83 = new Pharmacy_Management_System.Phm_dbDataSet83();
            this.tblmedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phm_dbDataSet71 = new Pharmacy_Management_System.Phm_dbDataSet71();
            this.tbl_medTableAdapter = new Pharmacy_Management_System.Phm_dbDataSet71TableAdapters.tbl_medTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbl_medTableAdapter1 = new Pharmacy_Management_System.Phm_dbDataSet83TableAdapters.tbl_medTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phm_dbDataSet83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phm_dbDataSet71)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 346;
            this.label3.Text = "Medicine Name:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PowderBlue;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(872, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 29);
            this.button7.TabIndex = 5;
            this.button7.Text = "Delete";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(872, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PowderBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Maroon;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(872, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Clear";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(516, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 29);
            this.textBox1.TabIndex = 1;
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
            this.button1.Location = new System.Drawing.Point(516, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 346;
            this.label1.Text = "Description:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(516, 67);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(341, 51);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snDataGridViewTextBoxColumn,
            this.medicineDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmedBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(384, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(594, 509);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            // 
            // medicineDataGridViewTextBoxColumn
            // 
            this.medicineDataGridViewTextBoxColumn.DataPropertyName = "Medicine";
            this.medicineDataGridViewTextBoxColumn.HeaderText = "Medicine";
            this.medicineDataGridViewTextBoxColumn.Name = "medicineDataGridViewTextBoxColumn";
            this.medicineDataGridViewTextBoxColumn.Width = 187;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 255;
            // 
            // tblmedBindingSource1
            // 
            this.tblmedBindingSource1.DataMember = "tbl_med";
            this.tblmedBindingSource1.DataSource = this.phm_dbDataSet83;
            // 
            // phm_dbDataSet83
            // 
            this.phm_dbDataSet83.DataSetName = "Phm_dbDataSet83";
            this.phm_dbDataSet83.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmedBindingSource
            // 
            this.tblmedBindingSource.DataMember = "tbl_med";
            this.tblmedBindingSource.DataSource = this.phm_dbDataSet71;
            // 
            // phm_dbDataSet71
            // 
            this.phm_dbDataSet71.DataSetName = "Phm_dbDataSet71";
            this.phm_dbDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_medTableAdapter
            // 
            this.tbl_medTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Goudy Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(384, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 29);
            this.button3.TabIndex = 349;
            this.button3.Text = "Back";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(481, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbl_medTableAdapter1
            // 
            this.tbl_medTableAdapter1.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(872, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Update";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1354, 733);
            this.shapeContainer1.TabIndex = 352;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.Location = new System.Drawing.Point(378, 2);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(607, 677);
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Medicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phm_dbDataSet83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phm_dbDataSet71)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Phm_dbDataSet71 phm_dbDataSet71;
        private System.Windows.Forms.BindingSource tblmedBindingSource;
        private Phm_dbDataSet71TableAdapters.tbl_medTableAdapter tbl_medTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private Phm_dbDataSet83 phm_dbDataSet83;
        private System.Windows.Forms.BindingSource tblmedBindingSource1;
        private Phm_dbDataSet83TableAdapters.tbl_medTableAdapter tbl_medTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}