using System;
using System.Collections.Generic;
using CALearningMangementSystem.Services;
using CALearningMangementSystem.Data;
using CALearningMangementSystem.Models;
using System.Text;

namespace CALearningMangementSystem.UI
{
    internal class StudentPortal 
    {

        public static void ShowStudentPortal(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Error: No logged-in student found.");
                return;
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to the Student Portal, {student.Name}!");
                Console.WriteLine("1. View available courses");
                Console.WriteLine("2. Enroll in a course");
                Console.WriteLine("3. View enrolled courses");
                Console.WriteLine("4. Logout");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ViewAvailableCourses();
                        break;
                    case "2":
                        EnrollInCourse(student);
                        break;
                    case "3":
                        ViewEnrolledCourses(student);
                        break;
                    case "4":
                        return; // Exit the portal
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        break;
                }
                Console.ReadKey(); // Wait for user input before clearing the console
            }
        }

        private static void ViewEnrolledCourses(Student student)
        {
            if (student.EnrolledCourses.Count == 0)
            {
                Console.WriteLine("You are not enrolled in any courses.");
                return;
            }
            for (int i = 0; i < student.EnrolledCourses.Count; i++)
            {
                var course = student.EnrolledCourses[i];
                Console.WriteLine($"{i + 1}. {course.Title} - {course.Description} - ${course.Price}");
            }
        }

        private static void EnrollInCourse(Student student)
        {
            if (InMemoryDatabase.Courses.Count == 0)
            {
                Console.WriteLine("No courses available to enroll in right now.");
                return;
            }

            ViewAvailableCourses();

            Console.Write("Enter the number of the course you want to enroll in: ");
            if (int.TryParse(Console.ReadLine(), out int courseNumber) && courseNumber > 0 && courseNumber <= InMemoryDatabase.Courses.Count)
            {
                var selectedCourse = InMemoryDatabase.Courses[courseNumber - 1];
                if (student.EnrolledCourses.Contains(selectedCourse))
                {
                    Console.WriteLine("You are already enrolled in this course!");
                    return;
                }
                student.EnrollInCourse(selectedCourse);
                Console.WriteLine($"You have successfully enrolled in {selectedCourse.Title}.");
                
                
            }
            else
            {
                Console.WriteLine("Invalid course number. Please try again.");
            }
        }

        private static void ViewAvailableCourses()
        {
            if (InMemoryDatabase.Courses.Count == 0)
            {
                Console.WriteLine("No courses available at the moment.");
                return;
            }
            for (int i = 0; i < InMemoryDatabase.Courses.Count; i++)
            {
                var course = InMemoryDatabase.Courses[i];
                Console.WriteLine($"{i + 1}. {course.Title} - {course.Description} - ${course.Price}");
            }
        }
    }
}
