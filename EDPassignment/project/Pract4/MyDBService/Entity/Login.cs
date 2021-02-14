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
    public class Login
    {
        // Define class properties
        public string UserID { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Password { get; set; }


        // Define a constructor to initialize all the properties
        public Login(string userid, string name, DateTime dob, string contact, string email, string country, string city, string postalcode, string password)
        {
            UserID = userid;
            Name = name;
            Dob = dob;
            Contact = contact;
            Email = email;
            Country = country;
            City = city;
            PostalCode = postalcode;
            Password = password;
        }

        public Login()
        {
        }

        public Login SelectByuserid(string UserID)
        {
            //Customer cust = new Customer("111", "Phoon LK", "Nanyang Polytechnic", "560860", "61234567", "91234567");
            //return cust;

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlstmt = "Select * from Login where userid = @paraUserID";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraUserID", UserID);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            int rec_cnt = ds.Tables[0].Rows.Count;
            Login obj = null;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string userid = row["userid"].ToString();
                string name = row["name"].ToString();
                DateTime dob = Convert.ToDateTime(row["dob"].ToString());
                string contact = row["contact"].ToString();
                string email = row["email"].ToString();
                string country = row["country"].ToString();
                string city = row["city"].ToString();
                string postalcode = row["postalcode"].ToString();
                string password = row["password"].ToString();


                obj = new Login(userid, name, dob,  contact, email, country, city, postalcode, password);
            }
            return obj;
        }




    }
}
