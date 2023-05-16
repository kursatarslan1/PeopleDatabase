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
        SqlConnection con = new SqlConnection();
        string connectionString;
        People p = new People();
        string value;
        public FormInfo()
        {
            InitializeComponent();
        }

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
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
            con.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM people WHERE Id="+ Id, con);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                p.Id = Convert.ToDecimal(reader["Id"]);
                p.Name = Convert.ToString(reader["Name"]);
                p.MiddleName = Convert.ToString(reader["MiddleName"]);
                p.LastName = Convert.ToString(reader["LastName"]);
                p.Birthday = Convert.ToDateTime(reader["Birthday"]);
                p.Address = Convert.ToString(reader["Address"]);
                p.Photo = (byte[])reader["Photo"];
                p.PhoneNumber = Convert.ToString(reader["PhoneNumber"]);
                p.Weight = Convert.ToInt32(reader["Weight"]);
                p.Height = Convert.ToInt32(reader["Height"]);
            }

            con.Close();
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
                string query = "DELETE FROM people WHERE Id=" + Id;
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ClearLabels();
                pictureBox1.Image = null;
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
            string query = "UPDATE people SET Name=@Name,MiddleName=@MiddleName,LastName=@LastName,PhoneNumber=@PhoneNumber,Weight=@Weight,Height=@Height,Address=@Address,Birthday=@Birthday WHERE Id=" + Id;
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Name",Convert.ToString(txtBoxName.Text));
            cmd.Parameters.AddWithValue("@MiddleName",Convert.ToString(txtBoxMiddleName.Text));
            cmd.Parameters.AddWithValue("@LastName",Convert.ToString(txtBoxLastName.Text));
            cmd.Parameters.AddWithValue("@PhoneNumber",Convert.ToString(txtBoxPhoneNumber.Text));
            cmd.Parameters.AddWithValue("@Weight",Convert.ToInt32(txtBoxWeight.Text));
            cmd.Parameters.AddWithValue("@Height",Convert.ToInt32(txtBoxHeight.Text));
            cmd.Parameters.AddWithValue("@Address",Convert.ToString(txtBoxAddress.Text));
            cmd.Parameters.AddWithValue("@Birthday",Convert.ToDateTime(dtpBirthday.Value));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetValues();
            SetValues();
            HideTextBox();
            btnUpdate.Enabled = true;
        }
    }
}
