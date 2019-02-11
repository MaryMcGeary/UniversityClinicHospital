using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class ReceptionistTest
    {
        [Fact]
        public void IsReceptionistOnThePhone()
        {
            var receptionist = new Receptionist("name", 111);

            receptionist.OnThePhone();

            Assert.True(receptionist.OnPhone);
        }
    }
}
