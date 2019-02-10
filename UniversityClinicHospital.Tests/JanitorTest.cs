using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class JanitorTest
    {
        [Fact]
        public void JanitorIsSweeping()
        {
            var janitor = new Janitor("name", 555);

            janitor.StartSweeping();

            Assert.True(janitor.IsSweeping);
        }
        
    }
}
