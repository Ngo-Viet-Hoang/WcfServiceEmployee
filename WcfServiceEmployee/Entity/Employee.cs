using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceEmployee.Entity
{
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Department { get; set; }


    }
}