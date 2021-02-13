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
    public class Booking
    {
        // Define class properties
        public string FacilityID { get; set; }
        public string FacilityName { get; set; }
        public string Sport { get; set; }
        public DateTime Date { get; set; }
        public string Duration { get; set; }
        public double Price { get; set; }

        public Booking()
        {

        }
        // Define a constructor to initialize all the properties
        public Booking(string facilityID, string facilityName, string sport, DateTime date, string duration, double price)
        {
            FacilityID = facilityID;
            FacilityName = facilityName;
            Sport = sport;
            Date = date;
            Duration = duration;
            Price = price;
        }


        public int Insert()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Create a SqlCommand object to add record with INSERT statement
            string sqlStmt = "INSERT INTO Booking (facilityID, facilityName, sport, date, duration, price) " +
                "VALUES (@paraFacilityID,@paraFacilityName, @paraSport, @paraDate, @paraDuration, @paraPrice)";
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraFacilityID", FacilityID);
            sqlCmd.Parameters.AddWithValue("@paraFacilityName", FacilityName);
            sqlCmd.Parameters.AddWithValue("@paraSport", Sport);
            sqlCmd.Parameters.AddWithValue("@paraDate", Date.ToShortDateString());
            sqlCmd.Parameters.AddWithValue("@paraDuration", Duration);
            sqlCmd.Parameters.AddWithValue("@paraPrice", Price);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            int result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public Booking SelectByFacilityID(string facilityID)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Booking where facilityID = @paraFacilityID";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraFacilityID", facilityID);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            Booking book = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string facilityName = row["facilityName"].ToString();
                string sport = row["sport"].ToString();
                DateTime date = Convert.ToDateTime(row["date"].ToString());
                string duration = row["duration"].ToString();
                string payStr = row["price"].ToString();
                double price = Convert.ToDouble(payStr);
                book = new Booking(facilityID, facilityName, sport, date, duration, price);
            }
            return book;
        }
        public List<Booking> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from Booking";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Booking> bookList = new List<Booking>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string facilityID = row["facilityID"].ToString();
                string facilityName = row["facilityName"].ToString();
                string sport = row["sport"].ToString();
                DateTime date = Convert.ToDateTime(row["date"].ToString());
                string duration = row["duration"].ToString();
                string payStr = row["price"].ToString();
                double price = Convert.ToDouble(payStr);
                Booking obj = new Booking(facilityID, facilityName, sport, date, duration, price);
                bookList.Add(obj);
            }
            return bookList;
        }
    }
}