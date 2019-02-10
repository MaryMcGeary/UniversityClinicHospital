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
            var receptionist = new Receptionist("name", 123);

            receptionist.GetOnThePhone();

            Assert.True(receptionist.OnPhone);
        }
    }
}
