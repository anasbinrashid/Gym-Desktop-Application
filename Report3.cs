﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet64.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter1.Fill(this.dbprojectDataSet64.trainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet63.dietplan' table. You can move, or remove it, as needed.
            this.dietplanTableAdapter1.Fill(this.dbprojectDataSet63.dietplan);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");

            conn.Open();

            string name = comboBox1.Text.ToString();
            string tname = comboBox2.Text.ToString();

            SqlCommand cmd = new SqlCommand("select member.username, member.memberid from member inner join dietplan on member.memberid=dietplan.dietplanid inner join trainer on dietplan.trainerid=trainer.trainerid where trainer.username=@Name and dietplan.diettype=@Tname ", conn);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Tname", tname);



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\ANAS\WORK\SEMESTER 4\Database Systems\Project\Project\Project\Report3.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            CompulosryReports a = new CompulosryReports();
            a.Show();   
        }
    }
}
