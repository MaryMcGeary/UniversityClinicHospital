using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public int BloodLevel { get; private set; }
        public int HealthLevel { get; private set; }

        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }

        public void SubtractBlood(int x)
        {
            BloodLevel -= x;
        }

        public void AddHealth(int x)
        {
            HealthLevel += x;
        }
    }
}
