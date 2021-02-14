using MyDBService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyDBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        List<Employee> GetAllEmployee();
        [OperationContract]
        Employee GetEmployeeByNric(string nric);
        [OperationContract]
        int CreateEmployee(string nric, string name, DateTime dob, string dept, double wage);

        [OperationContract]
        List<Booking> GetAllBooking();
        [OperationContract]
        Booking GetBookingByFacilityID(string facilityID);
        [OperationContract]
        int CreateBooking(string facilityID, string facilityName, string sport, DateTime date, string duration, double price);

        [OperationContract]
        List<UserInfo> GetAllUserInfo();
        [OperationContract]
        UserInfo GetUserInfoByUserID(string userID);
        [OperationContract]
        int CreateUserInfo(string name, DateTime dob, string contact, string email, string country, string city, string postalcode, string userID, string password);

        [OperationContract]
        Login GetLoginById(string userid);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MyDBService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
