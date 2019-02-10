using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class ReceptionistTest
    {
        [Fact]
        public void IsOnPhone()
        {
            // Arrange
            var receptionist = new Receptionist("name", 123);

            //Act
            receptionist.GetOnThePhone();

            //Assert
            Assert.True(receptionist.OnPhone);
        }
    }
}
