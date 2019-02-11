using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Hospital myHospital = new Hospital();
            Receptionist myReceptionist = new Receptionist("name", 12);
            Janitor myJanitor = new Janitor("name", 11);
            var patient = new Patient();
            bool run = true;

            do
            {

                Console.WriteLine("\n\nWelcome to University Clinic Hospital!");
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
                //string receptionistChoice;
                //string janitorChoice;

                if (char.IsDigit(keyPressed.KeyChar))
                {
                    menuChoice = keyPressed.KeyChar.ToString();
                    //doctorChoice = keyPressed.KeyChar.ToString();
                    //nurseChoice = keyPressed.KeyChar.ToString();
                    //receptionistChoice = keyPressed.KeyChar.ToString();
                    //janitorChoice = keyPressed.KeyChar.ToString();
                }
                else
                {
                    menuChoice = "default";
                    //doctorChoice = "default";
                    //nurseChoice = "default";
                    //receptionistChoice = "default";
                    //janitorChoice = "default";
                }

                switch (menuChoice)
                {
                    case "0":
                        Console.WriteLine("\n\nThanks for visiting University Clinic Hospital!");
                        run = false;
                        Console.ReadKey();
                        break;
                    case "1":
                        myHospital.ListEmployees();
                        break;
                    case "2":
                        //Make a doctorChoice() method??
                        Console.WriteLine("\n\nDoctor Choices:");
                        Console.WriteLine("Press 1 to have the doctor draw blood from patient");
                        Console.WriteLine("Press 2 to have the doctor care for the patient");
                        Console.WriteLine("Press 0 to Quit");
                        doctorChoice = Console.ReadLine();
                        //if (char.IsDigit(keyPressed.KeyChar))
                        //{
                        //    doctorChoice = keyPressed.KeyChar.ToString();
                        //}
                        switch (doctorChoice)
                        {
                            case "0":
                                Console.WriteLine("\nThanks for visiting University Clinic Hospital!");
                                break;
                            case "1":
                                myHospital.PerformTask("Doctor", 1);
                                Console.WriteLine($"\nThe patient's blood level is {patient.BloodLevel}\n");
                                break;
                            case "2":
                                myHospital.PerformTask("Doctor", 2);
                                Console.WriteLine($"\nThe patient's health level is {patient.HealthLevel}\n");
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        //Make a NurseChoice() method??
                        Console.WriteLine("\n\nNurse Choices:");
                        Console.WriteLine("Press 1 to have the nurse draw blood from patient");
                        Console.WriteLine("Press 2 to have the nurse care for the patient");
                        Console.WriteLine("Press 0 to Quit");
                        nurseChoice = Console.ReadLine();
                        //if (char.IsDigit(keyPressed.KeyChar))
                        //{
                        //    nurseChoice = keyPressed.KeyChar.ToString();
                        //}
                        switch (nurseChoice)
                        {
                            case "0":
                                Console.WriteLine("\nThanks for visiting University Clinic Hospital!");
                                break;
                            case "1":
                                myHospital.PerformTask("Nurse", 1);
                                Console.WriteLine($"\nThe patient's blood level is {patient.BloodLevel}\n");
                                break;
                            case "2":
                                myHospital.PerformTask("Nurse", 2);
                                Console.WriteLine($"\nThe patient's health level is {patient.HealthLevel}\n");
                                break;
                        }
                        break;
                    case "4":
                        myReceptionist.GetOnThePhone();
                        if (myReceptionist.OnPhone == true)
                        {
                            Console.WriteLine("\nThe receptionist is on the phone\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe receptionist is not on the phone\n");
                        }
                        break;
                    case "5":
                        myJanitor.StartSweeping();
                        if (myJanitor.IsSweeping == true)
                        {
                            Console.WriteLine("\nThe janitor is sweeping\n");
                        }
                        else
                        {
                            Console.WriteLine("\nThe janitor is not sweeping\n");
                        }
                        break;
                    case "6":
                        myHospital.PayEmployees();
                        break;
                    default:
                        Console.WriteLine("\nIncorrect entry. Try again.\n");
                        //Console.WriteLine("\nPress ANY KEY to continue");
                        //Console.ReadKey();
                        break;
                }
            } while (run);
        }
    }
}
