using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone = false;

        public Receptionist()
        {
        }
        
        public Receptionist(string name, int employeeNumber)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = 45000.00;
            TypeOfEmployee = "Receptionist";
            Paid = false;
        }

        public void GetOnThePhone()
        {
            OnPhone = true;
        }

        public void GetOffThePhone()
        {
            OnPhone = false;
        }
    }
}
