using System;
using System.Collections.Generic;
using System.Text;

namespace CALearningMangementSystem.Models
{
    internal class Instructor : User
    {
        public Instructor( string name, string phoneNumber, string password) : base( name, phoneNumber, password)
        {
            CreatedCourses = new List<Course>();
        }
        public List<Course> CreatedCourses { get; set; } 
        public void AddCourse(Course course)
        {
            CreatedCourses.Add(course);
        }
    }
}
