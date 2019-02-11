using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {  
        }

        static void MainMenu()
        {
            Hospital myHospital = new Hospital();
            Receptionist myReceptionist = new Receptionist();
            Janitor myJanitor = new Janitor();

            Console.WriteLine("Welcome to University Clinic Hospital!");
            Console.WriteLine("\nPress 1 see a list of employees and their attributes");
            Console.WriteLine("Press 2 to interact with the doctor");
            Console.WriteLine("Press 3 to interact with the nurse");
            Console.WriteLine("Press 4 to check if receptionist is on the phone");
            Console.WriteLine("Press 5 to check if janitor is sweeping");
            Console.WriteLine("Press 6 to pay the employees");
            Console.WriteLine("Press 0 to Quit");

            ConsoleKeyInfo keyPressed = Console.ReadKey();

            string menuChoice;
            string doctorChoice;
            string nurseChoice;
            string receptionistChoice;
            string janitorChoice;

            if (char.IsDigit(keyPressed.KeyChar))
            {
                menuChoice = keyPressed.KeyChar.ToString();
                doctorChoice = keyPressed.KeyChar.ToString();
                nurseChoice = keyPressed.KeyChar.ToString();
                receptionistChoice = keyPressed.KeyChar.ToString();
                janitorChoice = keyPressed.KeyChar.ToString();
            }
            else
            {
                menuChoice = "default";
                doctorChoice = "default";
                nurseChoice = "default";
                receptionistChoice = "default";
                janitorChoice = "default";
            }

           switch (menuChoice)
           {
                case "0":
                    Console.WriteLine("\nThanks for visiting University Clinic Hospital!");
                    break;
                case "1":
                    myHospital.ListEmployees();
                    break;
                case "2":
                    Console.WriteLine("\n\nDoctor Choices:");
                    Console.WriteLine("Press 1 to have the doctor draw blood from patient");
                    Console.WriteLine("Press 2 to have the doctor care for the patient");
                    Console.WriteLine("Press 0 to Quit");
                    switch (doctorChoice)
                    {
                        case "0":
                            Console.WriteLine("\nThanks for visiting University Clinic Hospital!");
                            break;
                        case "1":
                            myHospital.PerformTask("Doctor", 1);
                            break;
                        case "2":
                            myHospital.PerformTask("Doctor", 2);
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("\n\nNurse Choices:");
                    Console.WriteLine("Press 1 to have the nurse draw blood from patient");
                    Console.WriteLine("Press 2 to have the nurse care for the patient");
                    Console.WriteLine("Press 0 to Quit");
                    switch (nurseChoice)
                    {
                        case "0":
                            Console.WriteLine("\nThanks for visiting University Clinic Hospital!");
                            break;
                        case "1":
                            myHospital.PerformTask("Nurse", 1);
                            break;
                        case "2":
                            myHospital.PerformTask("Nurse", 2);
                            break;
                    }
                    break;
                case "4":
                    myReceptionist.GetOnThePhone();
                    if (myReceptionist.OnPhone == true)
                    {
                        Console.WriteLine("\nThe receptionist is on the phone");
                    }
                    else
                    {
                        Console.WriteLine("\nThe receptionist is not on the phone");
                    }
                    break;
                case "5":
                    myJanitor.StartSweeping();
                    if (myJanitor.IsSweeping == true)
                    {
                        Console.WriteLine("\nThe janitor is sweeping");
                    }
                    else
                    {
                        Console.WriteLine("\nThe janitor is not sweeping");
                    }
                    break;
                case "6":
                    myHospital.PayEmployees();
                    break;
                default:
                    Console.WriteLine("\nIncorrect entry. Try again.");
                    Console.WriteLine("\nPress ANY KEY to continue");
                    Console.ReadKey();
                    break;
           }
        }
    }
}
