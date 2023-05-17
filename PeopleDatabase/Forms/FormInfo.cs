using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace PeopleDatabase.Forms
{
    public partial class FormInfo : Form
    {
        readonly People p = new People();
        readonly SqlHelper sql = new SqlHelper();
        readonly string value;
        public  FormInfo(string id)
        {
            InitializeComponent();
            value = id;
        }
        public string Id { get; set; }
        private void FormInfo_Load(object sender, EventArgs e)
        {
            GetValues();
            SetValues();
            HideTextBox();
        }
        public void GetValues()
        {
            Id = value;
            p.Id = Convert.ToDecimal(value);
            sql.GetValues(p);
        }

        public void SetValues()
        {
            lblId.Text += p.Id;
            lblName.Text += p.Name;
            lblMiddleName.Text += p.MiddleName;
            lblSurname.Text += p.LastName;
            lblBirthday.Text += p.Birthday;
            lblAddress.Text += p.Address;
            lblPhoneNumber.Text += p.PhoneNumber;
            lblWeight.Text += p.Weight;
            lblHeight.Text += p.Height;
            using (MemoryStream ms = new MemoryStream(p.Photo))
            {
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;
            }
        }

        public void ClearLabels()
        {
            lblId.Text = "Id: ";
            lblName.Text = "Name: "; 
            lblMiddleName.Text = "Middle Name:";
            lblSurname.Text = "Surname: ";
            lblBirthday.Text = "Birthday: ";
            lblAddress.Text = "Address: ";
            lblPhoneNumber.Text = "Phone Number: ";
            lblWeight.Text = "Weight: ";
            lblHeight.Text = "Height: ";
        }

        public void HideTextBox()
        {
            txtBoxName.Visible = false;
            txtBoxMiddleName.Visible = false;
            txtBoxLastName.Visible = false;
            txtBoxPhoneNumber.Visible = false;
            txtBoxWeight.Visible = false;
            txtBoxHeight.Visible = false;
            txtBoxAddress.Visible = false;
            dtpBirthday.Visible = false;
            btnCompleteUpdate.Visible = false;
        }

        public void AppearTextBox()
        {
            txtBoxName.Visible = true;
            txtBoxMiddleName.Visible = true;
            txtBoxLastName.Visible = true;
            txtBoxPhoneNumber.Visible = true;
            txtBoxWeight.Visible = true;
            txtBoxHeight.Visible = true;
            txtBoxAddress.Visible = true;
            dtpBirthday.Visible = true;
            btnCompleteUpdate.Visible = true;
            ClearLabels();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure the delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                sql.Delete(p);
                ClearLabels();
                pictureBox1.Image = null;
                pictureBox1.BackColor = Color.Gray;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AppearTextBox();
            txtBoxName.Text = p.Name.ToString();
            txtBoxMiddleName.Text = p.MiddleName.ToString();
            txtBoxLastName.Text = p.LastName.ToString();
            txtBoxPhoneNumber.Text = p.PhoneNumber.ToString();
            txtBoxWeight.Text = p.Weight.ToString();
            txtBoxHeight.Text = p.Height.ToString();
            txtBoxAddress.Text = p.Address.ToString();
            dtpBirthday.Value = p.Birthday;
            btnUpdate.Enabled = false;
        }

        private void btnCompleteUpdate_Click(object sender, EventArgs e)
        {
            p.Name = txtBoxName.Text;
            p.MiddleName = txtBoxMiddleName.Text;
            p.LastName = txtBoxLastName.Text;
            p.Address = txtBoxAddress.Text;
            p.Weight = Convert.ToInt32(txtBoxWeight.Text);
            p.Height = Convert.ToInt32(txtBoxHeight.Text);
            p.Address = txtBoxAddress.Text;
            p.Birthday = dtpBirthday.Value;
            p.PhoneNumber = txtBoxPhoneNumber.Text;
            sql.Update(p);
            GetValues();
            SetValues();
            HideTextBox();
            btnUpdate.Enabled = true;
        }
    }
}
