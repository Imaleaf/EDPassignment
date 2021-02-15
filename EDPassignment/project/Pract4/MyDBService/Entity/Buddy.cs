using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MyDBService.Entity
{
    public class Buddy
    {
        // Define class properties
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Location { get; set; }
        public string Introduction { get; set; }
        public string Buddytype { get; set; }
        public string Buddygender { get; set; }
        public string Buddyduration { get; set; }
        public string Buddydays { get; set; }
        public string Buddyfitness { get; set; }
        public double Buddyage1 { get; set; }
        public double Buddyage2 { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public Buddy()
        {

        }
        // Define a constructor to initialize all the properties
        public Buddy(string name, string gender, DateTime dob, string location, string introduction, string buddytype, string buddygender, string buddyduration, string buddydays, string buddyfitness, double buddyage1, double buddyage2, string imagename, string imagepath)
        {
            Name = name;
            Gender = gender;
            Birthdate = dob;
            Location = location;
            Introduction = introduction;
            Buddytype = buddytype;
            Buddygender = buddygender;
            Buddyduration = buddyduration;
            Buddydays = buddydays;
            Buddyfitness = buddyfitness;
            Buddyage1 = buddyage1;
            Buddyage2 = buddyage2;
            ImageName = imagename;
            ImagePath = imagepath;
        }

        public int ComputeAge()
        {
            DateTime now = DateTime.Today;
            int age = DateTime.Today.Year - Birthdate.Year;
            if (now.Month < Birthdate.Month)
            {
                age--;
            }
            else
            {
                if (now.Month == Birthdate.Month && now.Day < Birthdate.Day)
                {
                    age--;
                }
            }
            return age;
        }

        public int Insert()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Create a SqlCommand object to add record with INSERT statement
            string sqlStmt = "INSERT INTO BuddySystem (name, gender, birthdate, location, introduction, buddytype, buddygender, buddyduration, buddydays, buddyfitness, buddyage1, buddyage2, imagename, imagepath) " +
                "VALUES (@paraName,@paraGender, @paraBirthdate, @paraLocation, @paraIntroduction, @paraBuddytype, @paraBuddygender, @paraBuddyduration, @paraBuddydays, @paraBuddyfitness, @paraBuddyage1, @paraBuddyage2, @ImageName, @ImagePath)";
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraGender", Gender);
            sqlCmd.Parameters.AddWithValue("@paraBirthdate", Birthdate);
            sqlCmd.Parameters.AddWithValue("@paraLocation", Location);
            sqlCmd.Parameters.AddWithValue("@paraIntroduction", Introduction);
            sqlCmd.Parameters.AddWithValue("@paraBuddytype", Buddytype);
            sqlCmd.Parameters.AddWithValue("@paraBuddygender", Buddygender);
            sqlCmd.Parameters.AddWithValue("@paraBuddyduration", Buddyduration);
            sqlCmd.Parameters.AddWithValue("@paraBuddydays", Buddydays);
            sqlCmd.Parameters.AddWithValue("@paraBuddyfitness", Buddyfitness);
            sqlCmd.Parameters.AddWithValue("@paraBuddyage1", Buddyage1);
            sqlCmd.Parameters.AddWithValue("@paraBuddyage2", Buddyage2);
            sqlCmd.Parameters.AddWithValue("@ImageName", ImageName);
            sqlCmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            int result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public Buddy SelectByName(string name)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from BuddySystem where name = @paraName";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraName", name);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            Buddy emp = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string gender = row["gender"].ToString();
                DateTime dob = Convert.ToDateTime(row["birthdate"].ToString());
                string location = row["location"].ToString();
                string introduction = row["introduction"].ToString();
                string buddytype = row["buddytype"].ToString();
                string buddygender = row["buddygender"].ToString();
                string buddyduration = row["buddyduration"].ToString();
                string buddydays = row["buddydays"].ToString();
                string buddyfitness = row["buddyfitness"].ToString();
                double buddyage1 = Convert.ToDouble(row["buddyage1"].ToString());
                double buddyage2 = Convert.ToDouble(row["buddyage2"].ToString());
                string imagename = row["imagename"].ToString();
                string imagepath = row["imagepath"].ToString();
                emp = new Buddy(name, gender, dob, location, introduction, buddytype, buddygender, buddyduration, buddydays, buddyfitness, buddyage1, buddyage2, imagename, imagepath);
            }
            return emp;
        }
        public List<Buddy> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from BuddySystem";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Buddy> empList = new List<Buddy>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string name = row["name"].ToString();
                string gender = row["gender"].ToString();
                DateTime dob = Convert.ToDateTime(row["birthdate"].ToString());
                string location = row["location"].ToString();
                string introduction = row["introduction"].ToString();
                string buddytype = row["buddytype"].ToString();
                string buddygender = row["buddygender"].ToString();
                string buddyduration = row["buddyduration"].ToString();
                string buddydays = row["buddydays"].ToString();
                string buddyfitness = row["buddyfitness"].ToString();
                double buddyage1 = Convert.ToDouble(row["buddyage1"].ToString());
                double buddyage2 = Convert.ToDouble(row["buddyage2"].ToString());
                string imagename = row["imagename"].ToString();
                string imagepath = row["imagepath"].ToString();
                Buddy obj = new Buddy(name, gender, dob, location, introduction, buddytype, buddygender, buddyduration, buddydays, buddyfitness, buddyage1, buddyage2, imagename, imagepath);
                empList.Add(obj);
            }
            return empList;
        }
        public int updateIntroduction(string userid, string introduction)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(DBConnect);
            string sql = "UPDATE BuddySystem SET introduction = @introduction WHERE name=@USERID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@USERID", userid);
            command.Parameters.AddWithValue("@introduction", introduction);

            connection.Open();
            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public int updateWorkoutDays(string userid, string workoutdays)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(DBConnect);
            string sql = "UPDATE BuddySystem SET buddydays = @buddydays WHERE name=@USERID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@USERID", userid);
            command.Parameters.AddWithValue("@buddydays", workoutdays);

            connection.Open();
            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public int updateWorkoutDuration(string userid, string workoutduration)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(DBConnect);
            string sql = "UPDATE BuddySystem SET buddyduration = @buddyduration WHERE name=@USERID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@USERID", userid);
            command.Parameters.AddWithValue("@buddyduration", workoutduration);

            connection.Open();
            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
        public int updateGender(string userid, string gender)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(DBConnect);
            string sql = "UPDATE BuddySystem SET gender = @gender WHERE name=@USERID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@USERID", userid);
            command.Parameters.AddWithValue("@gender", gender);

            connection.Open();
            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
        public int updateWorkoutType(string userid, string workouttype)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection connection = new SqlConnection(DBConnect);
            string sql = "UPDATE BuddySystem SET buddyfitness = @buddyfitness WHERE name=@USERID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@USERID", userid);
            command.Parameters.AddWithValue("@buddyfitness", workouttype);

            connection.Open();
            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;
        }
    }
}
