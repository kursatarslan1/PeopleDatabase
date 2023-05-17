using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase
{
    internal class SqlHelper
    {
        string connectionString;
        readonly SqlConnection con = new SqlConnection();
        DateTime dateTime = DateTime.UtcNow.Date;
        string logQuery = "INSERT INTO log (IpAddress, Process, ChangeDate, Change) VALUES (@IpAddress, @Process, @ChangeDate, @Change)";
        public SqlHelper() 
        {
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public void Create(People people)
        {
            string createQuery = "INSERT INTO people (Id, Name, MiddleName,LastName,Birthday,PhoneNumber,Address,Photo,Weight,Height) VALUES (@Id, @Name, @MiddleName, @LastName, @Birthday, @PhoneNumber, @Address, @Photo, @Weight, @Height)";
            SqlCommand cmd = new SqlCommand(createQuery, con);
            cmd.Parameters.AddWithValue("Id", people.Id);
            cmd.Parameters.AddWithValue("Name", people.Name);
            cmd.Parameters.AddWithValue("MiddleName", people.MiddleName);
            cmd.Parameters.AddWithValue("LastName", people.LastName);
            cmd.Parameters.AddWithValue("Birthday", people.Birthday);
            cmd.Parameters.AddWithValue("PhoneNumber", people.PhoneNumber);
            cmd.Parameters.AddWithValue("Address", people.Address);
            cmd.Parameters.AddWithValue("Photo", people.Photo);
            cmd.Parameters.AddWithValue("Weight", people.Weight);
            cmd.Parameters.AddWithValue("Height", people.Height);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlCommand cmnd = new SqlCommand(logQuery, con);
                cmnd.Parameters.AddWithValue("IpAddress", GetLocalIPAddress());
                cmnd.Parameters.AddWithValue("Process", "Create");
                cmnd.Parameters.AddWithValue("ChangeDate", dateTime);
                cmnd.Parameters.AddWithValue("Change", people.Id);
                cmnd.ExecuteNonQuery();
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
                con.Close(); 
            }
            con.Close();
        }

        public void Update(People people) 
        {
            string updateQuery = "UPDATE people SET Name=@Name,MiddleName=@MiddleName,LastName=@LastName,PhoneNumber=@PhoneNumber,Weight=@Weight,Height=@Height,Address=@Address,Birthday=@Birthday WHERE Id=" + people.Id;
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@Name", Convert.ToString(people.Name));
            cmd.Parameters.AddWithValue("@MiddleName", Convert.ToString(people.MiddleName));
            cmd.Parameters.AddWithValue("@LastName", Convert.ToString(people.LastName));
            cmd.Parameters.AddWithValue("@PhoneNumber", Convert.ToString(people.PhoneNumber));
            cmd.Parameters.AddWithValue("@Weight", Convert.ToInt32(people.Weight));
            cmd.Parameters.AddWithValue("@Height", Convert.ToInt32(people.Height));
            cmd.Parameters.AddWithValue("@Address", Convert.ToString(people.Address));
            cmd.Parameters.AddWithValue("@Birthday", Convert.ToDateTime(people.Birthday));
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlCommand cmnd = new SqlCommand(logQuery, con);
                cmnd.Parameters.AddWithValue("IpAddress", GetLocalIPAddress());
                cmnd.Parameters.AddWithValue("Process", "Update");
                cmnd.Parameters.AddWithValue("ChangeDate", dateTime);
                cmnd.Parameters.AddWithValue("Change", people.Id);
                cmnd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            con.Close();
        }

        public void Delete(People people) 
        {
            string deleteQuery = "DELETE FROM people WHERE Id=" + people.Id;
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SqlCommand cmnd = new SqlCommand(logQuery, con);
                cmnd.Parameters.AddWithValue("IpAddress", GetLocalIPAddress());
                cmnd.Parameters.AddWithValue("Process", "Delete");
                cmnd.Parameters.AddWithValue("ChangeDate", dateTime);
                cmnd.Parameters.AddWithValue("Change", people.Id);
                cmnd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            con.Close();
        }

        public void GetValues(People p)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM people WHERE Id=" + p.Id, con);
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

        public DataTable LoadData(int checkA)
        {
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
            string allDataQuery = "SELECT * FROM people";
            string logDataQuery = "SELECT * FROM log";
            using (con)
            {
                if (checkA == 0) 
                {
                    con.Open();
                    using (DataTable dt = new DataTable("people"))
                    {
                        SqlDataAdapter adptr = new SqlDataAdapter(allDataQuery, con);
                        adptr.Fill(dt);
                        con.Close();
                        return dt;
                    }
                }
                else
                {
                    con.Open();
                    using (DataTable dt = new DataTable("log"))
                    {
                        SqlDataAdapter adptr = new SqlDataAdapter(logDataQuery, con);
                        adptr.Fill(dt);
                        con.Close();
                        return dt;
                    }
                }
                
            }
        }

        public DataTable Filter(string value, int checkB)
        {
            connectionString = "data source=.;Initial Catalog=People;Integrated Security=True;";
            con.ConnectionString = connectionString;
            if (checkB == 0)
            {
                string filterQuery = "SELECT * FROM people WHERE Id LIKE '%" + value + "%' OR Name LIKE '%" + value + "%' OR MiddleName LIKE '%" + value + "%' OR LastName LIKE '%" + value + "%' OR PhoneNumber LIKE '%" + value + "%' OR Weight LIKE '%" + value + "%' OR Height LIKE '%" + value + "%' OR Address LIKE '%" + value + "%'";
                con.Open();

                using (DataTable dt = new DataTable("people"))
                {
                    SqlDataAdapter adptr = new SqlDataAdapter(filterQuery, con);
                    adptr.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            else
            {
                string filterQuery = "SELECT * FROM log WHERE IpAddress LIKE '%" + value + "%' OR Process LIKE '%" + value + "%' OR ChangeDate LIKE '%" + value + "%' OR Change LIKE '%" + value + "%'";
                con.Open();

                using (DataTable dt = new DataTable("people"))
                {
                    SqlDataAdapter adptr = new SqlDataAdapter(filterQuery, con);
                    adptr.Fill(dt);
                    con.Close();
                    return dt;
                }

            }
        }
    }
}
