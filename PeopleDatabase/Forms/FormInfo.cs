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
    }
}
