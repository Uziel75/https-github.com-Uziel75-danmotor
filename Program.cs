using System;
namespace danmotor
{
        internal class Program
        {
            static void Main()
            {
                Console.WriteLine(" Select a motor system concept:");
                Console.WriteLine("[1] (Thailand)");
                Console.WriteLine("[2] (Indonesia)");
                Console.WriteLine("[3] (Malaysia)");
                Console.WriteLine("[4] Exit");
                Console.Write("Enter your setup: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            ThailandMotor();
                            break;
                        case 2:
                            IndonesiaMotor();
                            break;
                        case 3:
                            MalaysiaMotor();
                            break;
                        case 4:
                            Console.WriteLine("thank you!");
                            return;
                        default:
                            Console.WriteLine(" Invalid motor set up. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid number setup.");
                }
            }

            // 🇹🇭 Thailand Concept: Irrigation Motor System
            static void ThailandMotor()
            {
                bool thiaMotor = false;

                while (true)
                {
                    Console.WriteLine("Motor System:");
                    Console.WriteLine("[1]  Rimset 17's");
                    Console.WriteLine("[2]  Lowered,open canister");
                    Console.WriteLine("[3]  Ligthen Swing Arm/faring");
                    Console.WriteLine("[4]  Back");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int action))
                    {
                        Console.Clear();

                        switch (action)
                        {
                            case 1:
                                thiaMotor = true;
                                Console.WriteLine("Rimset 17's");
                                break;
                            case 2:
                                thiaMotor = false;
                                Console.WriteLine("Lowered,open canister");
                                break;
                            case 3:
                                Console.WriteLine(thiaMotor ? "Ligthen Swing Arm/faring" : "No Ligthen Swing Arm/faring.");
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine(" Invalid thiasetup.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }

            // 🇮🇩 Indonesia Concept: Motorcycle Engine
            static void IndonesiaMotor()
            {
                bool indoMotor = false;
               
                while (true)
                {
                    Console.WriteLine("Motor System:");
                    Console.WriteLine("[1]  Mags 14's");
                    Console.WriteLine("[2]  Lowered");
                    Console.WriteLine("[3]  alloy crank");
                    Console.WriteLine("[4]  Back");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int action))
                    {
                        Console.Clear();

                        switch (action)
                        {
                            case 1:
                                indoMotor = true;
                                Console.WriteLine("Rimset 17's");
                                break;
                            case 2:
                                indoMotor = false;
                                Console.WriteLine("Lowered");
                                break;
                            case 3:
                                Console.WriteLine(indoMotor ? "alloy crank" : "No alloy crank");
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine(" Invalid indoMotor.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }
            
            static void MalaysiaMotor()
            {
                bool malayMotor = false;
                

                while (true)
                {
                     Console.WriteLine("Motor System:");
                    Console.WriteLine("[1]  CNC Mags 14's");
                    Console.WriteLine("[2]  Nickel GP4 Caliper");
                    Console.WriteLine("[3]  CNC crank");
                    Console.WriteLine("[4]  Back");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int action))
                    {
                        Console.Clear();

                        switch (action)
                        {
                            case 1:
                                malayMotor = true;
                                Console.WriteLine("CNC Mags 14's's");
                                break;
                            case 2:
                                malayMotor = false;
                                Console.WriteLine("Nickel GP4 Caliper");
                                break;
                            case 3:
                                Console.WriteLine(malayMotor ? "CNC crank" : "No CNC crank");
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine(" Invalid malayMotor.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }
        }
    }


    
