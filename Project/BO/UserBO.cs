using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Project.BO
{
    public class UserBO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Ride
    {
        public string RideName { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Persons { get; set; }
        public string AreaName { get; set; }
        public string EmployeeName { get; set; }
        
    }
    
    public class Show
    {
        public string ShowName { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Persons { get; set; }
        public string AreaName { get; set; }
        public string EmployeeName { get; set; }
        
    }


    public class EmployeeRideDuty
    {
        public string EmpName { get; set; }
        public string RideName { get; set; }
        public string Duty { get; set; }
        public int RideID { get; set; }
        public int EmpID { get; set; }
    }

    public class EmployeeShowDuty
    {
        public string EmpName { get; set; }
        public string ShowName { get; set; }
        public string Duty { get; set; }
        public int ShowID { get; set; }
        public int EmpID { get; set; }

    }

    public class EmployeeRideDelete
    {
        public string EmpName { get; set; }
        public int EmpID { get; set; }
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeCNIC { get; set; }
        public Nullable<int> Salary { get; set; }
        public string EmployeeSex { get; set; }
        public string EmployeeAdress { get; set; }
    }

}
