using System;
using System.Collections.Generic;
using CALearningMangementSystem.Models;
using System.Text;
using CALearningMangementSystem.Data;
using CALearningMangementSystem.Services;

namespace CALearningMangementSystem.UI
{
    internal class InstructorDashboard 
    {
        
        public static void ShowInstructorDashboard(Instructor instructor)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome, {instructor.Name}!");
                Console.WriteLine("1. Create a new course");
                Console.WriteLine("2. View your courses");
                Console.WriteLine("3. Logout");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateCourse(instructor);
                        break;
                    case "2":
                        ViewCourses(instructor);
                        break;
                    case "3":
                        return; // Exit the dashboard
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        break;
                }
                Console.ReadKey(); // Wait for user input before clearing the console
            }
        }

        private static void ViewCourses(Instructor instructor)
        {
            int courseCount = 0;
            for (int i = 0; i < InMemoryDatabase.Courses.Count; i++)
            {
                var course = InMemoryDatabase.Courses[i];
                if (course.InstructorId == instructor.PhoneNumber)
                {
                    courseCount++;
                    Console.WriteLine($"{courseCount}. {course.Title} - {course.Description} - ${course.Price}");
                }
            }
            if (courseCount == 0)
            {
                Console.WriteLine("You have not created any courses yet.");
            }
            
        }

        private static void CreateCourse(Instructor instructor)
        {
            string id = Guid.NewGuid().ToString();
            Console.WriteLine("Enter course title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter course description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Enter course price: ");
            decimal price = 0;
            while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid price.");
            }
            CourseService.CreateCourse(id, title, description, price, instructor.PhoneNumber);
            
        }
        
    }
}
