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
            //Arrange
            var patient = new Patient();
            var nurse = new Nurse("name", 555, 13);

            //Act
            nurse.DrawBlood(patient);
            
            //Assert
            Assert.Equal(16, patient.BloodLevel);
        }

        [Fact]
        public void patientWasCaredFor()
        {
            //Arrange
            var patient = new Patient();
            var nurse = new Nurse("name", 123, 13);

            //Act
            nurse.CareForPatient(patient);

            //Assert
            Assert.Equal(15, patient.HealthLevel);
        }
    }
}
