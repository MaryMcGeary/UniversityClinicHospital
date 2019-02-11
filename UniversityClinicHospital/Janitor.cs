using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool IsSweeping = false;

        public Janitor(string name, int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = 40000.00;
            TypeOfEmployee = "Janitor";
            Paid = false;
        }

        public void Sweeping()
        {
            IsSweeping = !IsSweeping;
        }
        
    }
}
