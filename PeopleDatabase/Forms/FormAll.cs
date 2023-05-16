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
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
            LoadData();
            dataGridView1.RowTemplate.Height = 235;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Forms.FormInfo frm = new Forms.FormInfo(dataGridView1.SelectedCells[0].Value.ToString());
            frm.Show();
        }
    }
}
