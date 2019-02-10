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
        }

        public void StartSweeping()
        {
            IsSweeping = true;
        }

        public void StopSweeping()
        {
            IsSweeping = false;
        }


    }
}
