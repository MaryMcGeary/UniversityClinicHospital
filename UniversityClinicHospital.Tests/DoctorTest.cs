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
            //Arrange
            var patient = new Patient();
            var doctor = new Doctor("name", 555, "specialty");

            //Act
            doctor.DrawBlood(patient);

            //Assert
            Assert.Equal(18, patient.BloodLevel);
        }

        [Fact]
        public void patientWasCaredFor()
        {
            //Arrange
            var patient = new Patient();
            var doctor = new Doctor("name", 123, "specialty");

            //Act
            doctor.CareForPatient(patient);

            //Assert
            Assert.Equal(20, patient.HealthLevel);
        }
    }
}
