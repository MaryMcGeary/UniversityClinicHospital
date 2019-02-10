using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class DoctorTest
    {
        [Fact]
        public void bloodWasDrawn()
        {
            var patient = new Patient();
            var doctor = new Doctor("name", 555, "specialty");

            doctor.DrawBlood(patient);

            Assert.Equal(18, patient.BloodLevel);
        }

        [Fact]
        public void patientWasCaredFor()
        {
            var patient = new Patient();
            var doctor = new Doctor("name", 123, "specialty");

            doctor.CareForPatient(patient);

            Assert.Equal(20, patient.HealthLevel);
        }
    }
}
