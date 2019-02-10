using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTest
    {
        [Fact]
        public void bloodWasDrawn()
        {
            var patient = new Patient();
            var nurse = new Nurse("name", 555, 13);

            nurse.DrawBlood(patient);
            
            Assert.Equal(16, patient.BloodLevel);
        }

        [Fact]
        public void patientWasCaredFor()
        {
            var patient = new Patient();
            var nurse = new Nurse("name", 123, 13);

            nurse.CareForPatient(patient);

            Assert.Equal(15, patient.HealthLevel);
        }
    }
}
