﻿using System;
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
        string connectionString;
        SqlConnection con = new SqlConnection();
        string filepath = "";
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
            txtBoxAge.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxWeight.Text = "";
            txtBoxHeight.Text = "";
            pbGetImage.Image = null;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
            con.Open();
            string query = "INSERT INTO people (Id, Name, MiddleName,LastName,Age,PhoneNumber,Address,Photo,Weight,Height)";
            query += " VALUES (@Id, @Name, @MiddleName, @LastName, @Age, @PhoneNumber, @Address, @Photo, @Weight, @Height)";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                People people = new People();
                people.Id = Convert.ToDecimal(txtBoxId.Text);
                people.Name = txtBoxName.Text;
                people.MiddleName = txtBoxMiddleName.Text;
                people.LastName = txtBoxSurname.Text;
                people.Age = Convert.ToInt32(txtBoxAge.Text);
                people.PhoneNumber = txtBoxPhoneNumber.Text;
                people.Address = txtBoxAddress.Text;
                people.Weight = Convert.ToInt32(txtBoxWeight.Text);
                people.Height = Convert.ToInt32(txtBoxHeight.Text);

                if (pbGetImage.Image != null)
                {
                    people.Photo = ConvertImageToBytes(pbGetImage.Image);
                }

                //MessageBox.Show("Id: " + people.Id + "\nName: " + people.Name + "\nMiddleName: " + people.MiddleName + "\nLastName: " + people.LastName + "\nAge: " + people.Age + "\nPhoneNumber: " + people.PhoneNumber + "\nAddress: " + people.Address + "\nWeight: " + people.Weight + "\nHeight: " + people.Height + "\nImage: " + people.Photo, "İşlem");
                
                cmd.Parameters.AddWithValue("Id", people.Id);
                cmd.Parameters.AddWithValue("Name", people.Name);
                cmd.Parameters.AddWithValue("MiddleName", people.MiddleName);
                cmd.Parameters.AddWithValue("LastName", people.LastName);
                cmd.Parameters.AddWithValue("Age", people.Age);
                cmd.Parameters.AddWithValue("PhoneNumber", people.PhoneNumber);
                cmd.Parameters.AddWithValue("Address", people.Address);
                cmd.Parameters.AddWithValue("Photo", people.Photo);
                cmd.Parameters.AddWithValue("Weight", people.Weight);
                cmd.Parameters.AddWithValue("Height", people.Height);

                DialogResult res = MessageBox.Show("Id: " + people.Id + "\nName: " + people.Name + "\nMiddleName: " + people.MiddleName + "\nLastName: " + people.LastName + "\nAge: " + people.Age + "\nPhoneNumber: " + people.PhoneNumber + "\nAddress: " + people.Address + "\nWeight: " + people.Weight + "\nHeight: " + people.Height + "\nImage: " + people.Photo + "\n\nEklemek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(res == DialogResult.OK)
                    cmd.ExecuteNonQuery();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

            con.Close();  
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data)) 
            {
                return Image.FromStream(ms);
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
    }
}