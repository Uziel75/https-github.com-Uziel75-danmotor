using System;
namespace danmotor
{
        internal class Program
        {
            static void Main()
            {
                Console.WriteLine(" Select a motor system concept:");
                Console.WriteLine("[1] Irrigation Motor (Thailand)");
                Console.WriteLine("[2] Motorcycle Engine (Indonesia)");
                Console.WriteLine("[3] Industrial Conveyor (Malaysia)");
                Console.WriteLine("[4] Exit");
                Console.Write("Enter your choice: ");

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
                    Console.WriteLine("⚠️ Please enter a valid number.");
                }
            }

            // 🇹🇭 Thailand Concept: Irrigation Motor System
            static void ThailandMotor()
            {
                bool pumpMotor = false;

                while (true)
                {
                    Console.WriteLine("Motor System:");
                    Console.WriteLine("[1]  Turn On Water Pump");
                    Console.WriteLine("[2]  Turn Off Water Pump");
                    Console.WriteLine("[3]  Check Water Flow");
                    Console.WriteLine("[4]  Back");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int action))
                    {
                        Console.Clear();

                        switch (action)
                        {
                            case 1:
                                pumpMotor = true;
                                Console.WriteLine("✅ Water pump is now ON.");
                                break;
                            case 2:
                                pumpMotor = false;
                                Console.WriteLine("⛔ Water pump is now OFF.");
                                break;
                            case 3:
                                Console.WriteLine(pumpMotor ? "🌊 Water is flowing." : "🚱 No water flow detected.");
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine(" Invalid motor setup.");
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
                bool engineOn = false;
                int speed = 0;
                int fuelLevel = 100;

                while (true)
                {
                    Console.WriteLine(" motor System:");
                    Console.WriteLine("[1]  Start Engine");
                    Console.WriteLine("[2] Increase Speed");
                    Console.WriteLine("[3] Check Fuel Level");
                    Console.WriteLine("[4] Stop Engine");
                    Console.WriteLine("[5] Back");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int action))
                    {
                        Console.Clear();

                        switch (action)
                        {
                            case 1:
                                engineOn = true;
                                Console.WriteLine(" Engine started.");
                                break;
                            case 2:
                                if (engineOn && fuelLevel > 0)
                                {
                                    speed += 10;
                                    fuelLevel -= 5;
                                    Console.WriteLine($"Speed increased to {speed} km/h.");
                                }
                                else
                                {
                                    Console.WriteLine(" Engine is off or fuel is empty!");
                                }
                                break;
                            case 3:
                                Console.WriteLine($" Fuel level: {fuelLevel}%.");
                                break;
                            case 4:
                                engineOn = false;
                                speed = 0;
                                Console.WriteLine(" Engine stopped.");
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine(" Invalid motor set up.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Please enter a valid number.");
                    }
                }
            }

            
            static void MalaysiaMotor()
            {
                bool conveyorRunning = false;
                int speed = 0;

                while (true)
                {
                    Console.WriteLine(" motor System:");
                    Console.WriteLine("[1]  Start motor");
                    Console.WriteLine("[2]  Increase Speed");
                    Console.WriteLine("[3] Decrease Speed");
                    Console.WriteLine("[4] Stop motor");
                    Console.WriteLine("[5] Back");
                    Console.Write("Enter your choice: ");

                    if (int.TryParse(Console.ReadLine(), out int action))
                    {
                        Console.Clear();

                        switch (action)
                        {
                            case 1:
                                conveyorRunning = true;
                                Console.WriteLine(" motor is now running.");
                                break;
                            case 2:
                                if (conveyorRunning)
                                {
                                    speed += 5;
                                    Console.WriteLine($"motor increased to {speed} RPM.");
                                }
                                else
                                {
                                    Console.WriteLine(" moor is OFF! Please turn it on first.");
                                }
                                break;
                            case 3:
                                if (conveyorRunning && speed > 0)
                                {
                                    speed -= 5;
                                    Console.WriteLine($"  motor decreased to {speed} RPM.");
                                }
                                else
                                {
                                    Console.WriteLine(" motor is already at minimum speed.");
                                }
                                break;
                            case 4:
                                conveyorRunning = false;
                                speed = 0;
                                Console.WriteLine(" motor stopped.");
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine(" Invalid motor setup.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Please enter a valid number.");
                    }
                }
            }
        }
    }


    