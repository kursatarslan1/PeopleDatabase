using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase.Forms
{
    public partial class FormAdd : Form
    {
        People people = new People();
        SqlHelper sql = new SqlHelper();
        string filepath = "";
        bool checkPhoneNumber;
        public FormAdd()
        {
            InitializeComponent();

        }

        private void pbGetImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select Photo";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr== DialogResult.OK)
            {
                foreach(String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        filepath = file;
                        pbGetImage.Height = 275;
                        pbGetImage.Width = 265;

                        Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        Bitmap myBitmap = new Bitmap(file);
                        Image myThumbnail = myBitmap.GetThumbnailImage(300, 300, myCallback, IntPtr.Zero);
                        pbGetImage.Image = myThumbnail;

                    }
                    
                    catch (Exception ex)
                    {
                       MessageBox.Show("Error : " + ex.Message);
                    }
                }
            }
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        private void btnCleanFields_Click(object sender, EventArgs e)
        {
            txtBoxId.Text = "";
            txtBoxName.Text = "";
            txtBoxMiddleName.Text = "";
            txtBoxSurname.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxWeight.Text = "";
            txtBoxHeight.Text = "";
            pbGetImage.Image = null;
        }

        public void GetValues()
        {
            people.Id = Convert.ToDecimal(txtBoxId.Text);
            people.Name = txtBoxName.Text;
            people.MiddleName = txtBoxMiddleName.Text;
            people.LastName = txtBoxSurname.Text;
            people.Birthday = dtpBirthday.Value;
            people.PhoneNumber = txtBoxPhoneNumber.Text;
            people.Address = txtBoxAddress.Text;
            people.Weight = Convert.ToInt32(txtBoxWeight.Text);
            people.Height = Convert.ToInt32(txtBoxHeight.Text);

            if (pbGetImage.Image != null)
            {
                people.Photo = ConvertImageToBytes(pbGetImage.Image);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues();
                DialogResult res = MessageBox.Show("Id: " + people.Id + "\nName: " + people.Name + "\nMiddleName: " + people.MiddleName + "\nLastName: " + people.LastName + "\nAge: " + people.Birthday + "\nPhoneNumber: " + people.PhoneNumber + "\nAddress: " + people.Address + "\nWeight: " + people.Weight + "\nHeight: " + people.Height + "\nImage: " + people.Photo + "\n\nEklemek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(res == DialogResult.OK)
                    sql.Create(people);
                
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                if (error.Contains("PRIMARY KEY"))
                    MessageBox.Show("Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    MessageBox.Show("" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void pbGetImage_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbGetImage_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {   
            if(txtBoxPhoneNumber.Text.Length == 1)
            {
                checkPhoneNumber = true;
            }

            if(checkPhoneNumber == true)
            {
                string s = txtBoxPhoneNumber.Text;
                if (s.Length == 10)
                {
                    double sAsD = double.Parse(s);
                    txtBoxPhoneNumber.Text = string.Format("{0:+90 (###) ### ## ##}", sAsD).ToString();
                    checkPhoneNumber = false;
                }
                if (txtBoxPhoneNumber.Text.Length > 1)
                    txtBoxPhoneNumber.SelectionStart = txtBoxPhoneNumber.Text.Length;
                txtBoxPhoneNumber.SelectionLength = 0;
            }
        }

        private void txtBoxId_Click(object sender, EventArgs e)
        {
            txtBoxId.SelectionStart = 0;
        }

        private void txtBoxPhoneNumber_Click(object sender, EventArgs e)
        {
            txtBoxPhoneNumber.SelectionStart = 0;
        }

        private void txtBoxWeight_Click(object sender, EventArgs e)
        {
            txtBoxWeight.SelectionStart = 0;
        }

        private void txtBoxHeight_Click(object sender, EventArgs e)
        {
            txtBoxHeight.SelectionStart = 0;
        }
    }
}
