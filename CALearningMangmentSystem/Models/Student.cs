using System;
using System.Collections.Generic;
using System.Text;

namespace CALearningMangementSystem.Models
{
    internal class Student : User
    {
        public Student( string name,  string password, string phone)
            : base( name, password, phone)
        {
            EnrolledCourses = new List<Course>();
        }
        public List<Course> EnrolledCourses { get; set; } 
        public void EnrollInCourse(Course course)
        {
            EnrolledCourses.Add(course);
        }
    }
}
