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
            // Arrange
            var janitor = new Janitor("name", 555);

            // Act
            janitor.StartSweeping();

            // Assert
            Assert.True(janitor.IsSweeping);
        }
        
    }
}
