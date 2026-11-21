using CALearningMangementSystem.Services;
using CALearningMangementSystem.UI;
using CALearningMangementSystem.Models;


namespace CALearningMangementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Welcome to Manstek Platform ===");
                Console.WriteLine("1- New Registration for Students");
                Console.WriteLine("2- New Registration for Instructors");
                Console.WriteLine("3- Login");
                Console.WriteLine("4- Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                try
                {
                    if (choice == "1")
                    {
                        Console.WriteLine("\n--- Student Registration ---");
                        Console.Write("Enter your name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter your phone: ");
                        var phone = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        var password = Console.ReadLine();

                        UserService.RegisterStudent(name, phone, password);
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("\n--- Instructor Registration ---");
                        Console.Write("Enter your name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter your phone: ");
                        var phone = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        var password = Console.ReadLine();

                        UserService.RegisterInstructor(name, phone, password);
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("\n--- Login ---");
                        Console.Write("Enter your phone: ");
                        var phone = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        var password = Console.ReadLine();

                        var user = UserService.Login(phone, password);
                        Console.WriteLine($"\nWelcome back, {user.Name}!");
                        if (user is Instructor instructor)
                        {
                            InstructorDashboard.ShowInstructorDashboard(instructor);
                        }

                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("Exiting program. Goodbye!");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[Error]: {ex.Message}");
                }

                Console.WriteLine("\n-----------------------------------");
            }
        }
    }
}
