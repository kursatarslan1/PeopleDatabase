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
        readonly SqlHelper sql = new SqlHelper();
        public FormAll()
        {
            InitializeComponent();
        }

        private void FormAll_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.LoadData(0);
            dataGridView1.RowTemplate.Height = 235;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormInfo frm = new FormInfo(dataGridView1.SelectedCells[1].Value.ToString());
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.LoadData(0);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.Filter(txtBoxSearch.Text,0);

        }
    }
}
