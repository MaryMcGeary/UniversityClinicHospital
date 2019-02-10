using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; private set; }

        public Doctor(string name, int employeeNumber, string specialty)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Specialty = specialty;
        }

        public void DrawBlood(Patient patient)
        {
            patient.SubtractBlood(2);
        }

        public void CareForPatient(Patient patient)
        {
            patient.AddHealth(10);
        }
    }
}
