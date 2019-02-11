using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class JanitorTest
    {
        [Fact]
        public void Sweeping()
        {
            var janitor = new Janitor("name", 111);

            janitor.Sweeping();

            Assert.True(janitor.IsSweeping);
        }
        
    }
}
