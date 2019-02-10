using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; private set; }

        public Nurse(string name, int employeeNumber, int numberOfPatients)
        {
            Name = name;
            EmployeeNumber = employeeNumber;            
            NumberOfPatients = numberOfPatients;
        }

        public void DrawBlood(Patient patient)
        {
            patient.SubtractBlood(4);
        }

        public void CareForPatient(Patient patient)
        {
            patient.AddHealth(5);
        }
    }
}
