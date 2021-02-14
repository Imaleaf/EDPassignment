using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MyDBService.Entity
{
    public class UserInfo
    {

        // Define class properties
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }


        public UserInfo()
        {

        }
        // Define a constructor to initialize all the properties
        public UserInfo(string name, DateTime dob, string contact, string email, string country, string city, string postalcode, string userid, string password)
        {
            Name = name;
            Dob = dob;
            Contact = contact;
            Email = email;
            Country = country;
            City = city;
            PostalCode = postalcode;
            UserID = userid;
            Password = password;
        }


        public int Insert()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Create a SqlCommand object to add record with INSERT statement
            string sqlStmt = "INSERT INTO UserInfo (name, dob, contact, email, country, city, postalcode, userid, password) " +
                "VALUES (@paraName,@paraDob, @paraContact, @paraEmail, @paraCountry, @paraCity, @paraPostalCode, @paraUserID, @paraPassword)";
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraDob", Dob.ToShortDateString());
            sqlCmd.Parameters.AddWithValue("@paraContact", Contact);
            sqlCmd.Parameters.AddWithValue("@paraEmail", Email);
            sqlCmd.Parameters.AddWithValue("@paraCountry", Country);
            sqlCmd.Parameters.AddWithValue("@paraCity", City);
            sqlCmd.Parameters.AddWithValue("@paraPostalCode", PostalCode);
            sqlCmd.Parameters.AddWithValue("@paraUserID", UserID);
            sqlCmd.Parameters.AddWithValue("@paraPassword", Password);
         

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            int result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public UserInfo SelectByUserID(string userID)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from UserInfo where userID = @paraUserID";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraUserID", userID);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            UserInfo info = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string name = row["name"].ToString();
                DateTime dob = Convert.ToDateTime(row["dob"].ToString());
                string contact = row["contact"].ToString();
                string email = row["email"].ToString();
                string country = row["country"].ToString();
                string city = row["city"].ToString();
                string postalcode = row["postalcode"].ToString();
                string password = row["password"].ToString();
                info = new UserInfo(name, dob, contact, email, country, city, postalcode, userID, password);
            }
            return info;
        }
        public List<UserInfo> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from UserInfo";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<UserInfo> infoList = new List<UserInfo>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string name = row["name"].ToString();
                DateTime dob = Convert.ToDateTime(row["dob"].ToString());
                string contact = row["contact"].ToString();
                string email = row["email"].ToString();
                string country = row["country"].ToString();
                string city = row["city"].ToString();
                string postalcode = row["postalcode"].ToString();
                string userID = row["userID"].ToString();
                string password = row["password"].ToString();
                UserInfo obj = new UserInfo(name, dob, contact, email, country, city, postalcode, userID, password);
                infoList.Add(obj);
            }
            return infoList;
        }
    }
}
