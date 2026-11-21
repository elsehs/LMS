using CALearningMangementSystem.Data;
using CALearningMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CALearningMangementSystem.Services
{
    internal class CourseService
    {
        public static void CreateCourse(string id, string title, string description, decimal price, string instructorId)
        {
            var course = new Course(id, title, description, price, instructorId);

            InMemoryDatabase.Courses.Add(course);

            Console.WriteLine($" Course created successfully: {title}");
        }
        public List<Course> GetAllCourses()
        {
            return InMemoryDatabase.Courses;
        }
    }
}
