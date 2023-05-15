﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase.Forms
{
    public partial class FormAll : Form
    {
        SqlConnection con = new SqlConnection();
        string connectionString;
        public FormAll()
        {
            InitializeComponent();
        }

        private void FormAll_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'peopleDataSet3.people' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.peopleTableAdapter.Fill(this.peopleDataSet3.people);
            // TODO: Bu kod satırı 'peopleDataSet.people' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
            LoadData();
            dataGridView1.RowTemplate.Height = 235;
        }

        public void LoadData()
        {
            using (con)
            {
                con.Open();
                using (DataTable dt = new DataTable("people"))
                {
                    SqlDataAdapter adptr = new SqlDataAdapter("select * from people", con);
                    adptr.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                con.Close();
            }
        }
    }
}
