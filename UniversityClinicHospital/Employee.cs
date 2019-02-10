using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public string Name { get; protected set; }
        public int EmployeeNumber { get; protected set; }
        public double Salary { get; protected set; }
        public bool Paid = false;
        public string TypeOfEmployee { get; protected set; }
    }
}
