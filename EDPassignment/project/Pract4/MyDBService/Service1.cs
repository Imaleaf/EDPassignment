using MyDBService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyDBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public List<Employee> GetAllEmployee()
        {
            Employee emp = new Employee();
            return emp.SelectAll();
        }
        public Employee GetEmployeeByNric(string nric)
        {
            Employee emp = new Employee();
            return emp.SelectByNric(nric);
        }
        public int CreateEmployee(string nric, string name, DateTime dob, string dept, double wage)
        {
            Employee emp = new Employee(nric, name, dob, dept, wage);
            return emp.Insert();
        }

        public List<Booking> GetAllBooking()
        {
            Booking book = new Booking();
            return book.SelectAll();
        }
        public Booking GetBookingByFacilityID(string facilityID)
        {
            Booking book = new Booking();
            return book.SelectByFacilityID(facilityID);
        }
        public int CreateBooking(string facilityID, string facilityName, string sport, DateTime date, string duration, double price)
        {
            Booking book = new Booking(facilityID, facilityName, sport, date, duration, price);
            return book.Insert();
        }

        public List<UserInfo> GetAllUserInfo()
        {
            UserInfo info = new UserInfo();
            return info.SelectAll();
        }
        public UserInfo GetUserInfoByUserID(string userID)
        {
            UserInfo info = new UserInfo();
            return info.SelectByUserID(userID);
        }
        public int CreateUserInfo(string name, DateTime dob, string contact, string email, string country, string city, string postalcode, string userID, string password)
        {
            UserInfo info = new UserInfo(name, dob, contact, email, country, city, postalcode, userID, password);
            return info.Insert();
        }

    }
}
