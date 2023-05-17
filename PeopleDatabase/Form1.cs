using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace PeopleDatabase
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        SqlHelper sql = new SqlHelper();
        public MainForm()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    btnCloseChildForm.Visible = true;
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMiddle.Controls.Add(childForm);
            this.pnlMiddle.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnAllPeople_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAll(), sender);
        }

        private void btnAddPeople_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdd(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            lblTitle.Text = "PEOPLE DATABASE";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void btnGetLogs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.LoadData(1);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.Filter(txtBoxSearch.Text, 1);
        }
    }
}
