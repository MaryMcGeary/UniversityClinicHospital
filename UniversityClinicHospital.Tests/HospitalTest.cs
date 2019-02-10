using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class HospitalTest
    {
        [Fact]
        public void canEmployeeListBeMade()
        {
            Hospital myHospital = new Hospital();

            myHospital.Employees.Add(new Doctor("Name", 123, "Specialty"));
            
            Assert.NotEmpty(myHospital.Employees);
        }

        [Fact]
        public void wereEmployeesPaid()
        {
            var myHospital = new Hospital();
            var doctor = new Doctor("name", 111, "specialty"); 
            myHospital.Employees.Add(doctor); 

            myHospital.PayEmployees(); 

            Assert.True(doctor.Paid);          
        } 
    } 
}
