using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Hospital
    {
        public List<Employee> Employees;
        public Patient Sue;

        public Doctor doctor;
        public Nurse nurse;
        public Receptionist receptionist;
        public Janitor janitor;

        public Hospital()
        {
            Employees = new List<Employee>();
            Sue = new Patient();

            doctor = new Doctor("Dr. Ruth", 789, "Heart Surgeon");
            nurse = new Nurse("Joe", 237, 15);
            receptionist = new Receptionist("Bill", 612);
            janitor = new Janitor("Daisy", 119);

            Employees.Add(doctor);
            Employees.Add(nurse);
            Employees.Add(receptionist);
            Employees.Add(janitor);
        }
        
        public void PayEmployees()
        {
            foreach (var employee in Employees)
            {
                if (employee.Paid == false)
                {
                    employee.PaySalary();
                }
                else
                {
                    Console.WriteLine($"\nThe {employee.TypeOfEmployee}, Employee #{employee.EmployeeNumber}, has already been paid.");
                }
            }
        }

        public void ListEmployees()
        {
            foreach (var employee in Employees)
            {
                employee.ListAttributes();
            }
        }

        public void PerformTask(string employeeType, int task)
        {
            switch (employeeType)
            {
                case "Doctor":
                    switch (task)
                    {
                        case 1:
                            doctor.DrawBlood(Sue);
                            break;

                        case 2:
                            doctor.CareForPatient(Sue);
                            break;
                    }
                    break;

                case "Nurse":
                    switch (task)
                    {
                        case 1:
                            nurse.DrawBlood(Sue);
                            break;

                        case 2:
                            nurse.CareForPatient(Sue);
                            break;
                    }
                    break;
            }
        }
    }
}
