﻿namespace Project
{
    partial class Report3
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
            this.gymTableAdapter1 = new Project.dbprojectDataSet62TableAdapters.gymTableAdapter();
            this.dbprojectDataSet62 = new Project.dbprojectDataSet62();
            this.dietplanTableAdapter = new Project.dbprojectDataSet61TableAdapters.dietplanTableAdapter();
            this.dietplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet61 = new Project.dbprojectDataSet61();
            this.trainerTableAdapter = new Project.dbprojectDataSet60TableAdapters.trainerTableAdapter();
            this.dbprojectDataSet60 = new Project.dbprojectDataSet60();
            this.gymBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gymTableAdapter = new Project.dbprojectDataSet59TableAdapters.gymTableAdapter();
            this.dbprojectDataSet59 = new Project.dbprojectDataSet59();
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trainerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet64 = new Project.dbprojectDataSet64();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbprojectDataSet63 = new Project.dbprojectDataSet63();
            this.dietplanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dietplanTableAdapter1 = new Project.dbprojectDataSet63TableAdapters.dietplanTableAdapter();
            this.trainerTableAdapter1 = new Project.dbprojectDataSet64TableAdapters.trainerTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gymTableAdapter1
            // 
            this.gymTableAdapter1.ClearBeforeFill = true;
            // 
            // dbprojectDataSet62
            // 
            this.dbprojectDataSet62.DataSetName = "dbprojectDataSet62";
            this.dbprojectDataSet62.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter
            // 
            this.dietplanTableAdapter.ClearBeforeFill = true;
            // 
            // dietplanBindingSource
            // 
            this.dietplanBindingSource.DataMember = "dietplan";
            this.dietplanBindingSource.DataSource = this.dbprojectDataSet61;
            // 
            // dbprojectDataSet61
            // 
            this.dbprojectDataSet61.DataSetName = "dbprojectDataSet61";
            this.dbprojectDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // dbprojectDataSet60
            // 
            this.dbprojectDataSet60.DataSetName = "dbprojectDataSet60";
            this.dbprojectDataSet60.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource1
            // 
            this.gymBindingSource1.DataMember = "gym";
            this.gymBindingSource1.DataSource = this.dbprojectDataSet62;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "trainer";
            this.trainerBindingSource.DataSource = this.dbprojectDataSet60;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
            // 
            // dbprojectDataSet59
            // 
            this.dbprojectDataSet59.DataSetName = "dbprojectDataSet59";
            this.dbprojectDataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "gym";
            this.gymBindingSource.DataSource = this.dbprojectDataSet59;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.trainerBindingSource1;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "trainerid";
            // 
            // trainerBindingSource1
            // 
            this.trainerBindingSource1.DataMember = "trainer";
            this.trainerBindingSource1.DataSource = this.dbprojectDataSet64;
            // 
            // dbprojectDataSet64
            // 
            this.dbprojectDataSet64.DataSetName = "dbprojectDataSet64";
            this.dbprojectDataSet64.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(908, 457);
            this.reportViewer1.TabIndex = 17;
            // 
            // dbprojectDataSet63
            // 
            this.dbprojectDataSet63.DataSetName = "dbprojectDataSet63";
            this.dbprojectDataSet63.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanBindingSource1
            // 
            this.dietplanBindingSource1.DataMember = "dietplan";
            this.dietplanBindingSource1.DataSource = this.dbprojectDataSet63;
            // 
            // dietplanTableAdapter1
            // 
            this.dietplanTableAdapter1.ClearBeforeFill = true;
            // 
            // trainerTableAdapter1
            // 
            this.trainerTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            " Intermittent Fasting",
            " Keto Diet (Ketogenic Diet)",
            " Low-Carb Diet",
            " Low-Fat Diet",
            " Mediterranean Diet",
            " Paleo Diet",
            " Vegan Diet",
            " Vegetarian Diet"});
            this.comboBox2.Location = new System.Drawing.Point(389, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 24);
            this.comboBox2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(604, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 88;
            this.button2.Text = "LOAD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(762, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 46);
            this.button5.TabIndex = 87;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 89;
            this.label3.Text = "Diet Plan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 90;
            this.label2.Text = "Trainer";
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report3";
            this.Text = "Report3";
            this.Load += new System.EventHandler(this.Report3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbprojectDataSet62TableAdapters.gymTableAdapter gymTableAdapter1;
        private dbprojectDataSet62 dbprojectDataSet62;
        private dbprojectDataSet61TableAdapters.dietplanTableAdapter dietplanTableAdapter;
        private System.Windows.Forms.BindingSource dietplanBindingSource;
        private dbprojectDataSet61 dbprojectDataSet61;
        private dbprojectDataSet60TableAdapters.trainerTableAdapter trainerTableAdapter;
        private dbprojectDataSet60 dbprojectDataSet60;
        private System.Windows.Forms.BindingSource gymBindingSource1;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private dbprojectDataSet59TableAdapters.gymTableAdapter gymTableAdapter;
        private dbprojectDataSet59 dbprojectDataSet59;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbprojectDataSet63 dbprojectDataSet63;
        private System.Windows.Forms.BindingSource dietplanBindingSource1;
        private dbprojectDataSet63TableAdapters.dietplanTableAdapter dietplanTableAdapter1;
        private dbprojectDataSet64 dbprojectDataSet64;
        private System.Windows.Forms.BindingSource trainerBindingSource1;
        private dbprojectDataSet64TableAdapters.trainerTableAdapter trainerTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}