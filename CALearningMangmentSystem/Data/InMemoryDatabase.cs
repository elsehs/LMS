using System;
using System.Collections.Generic;
using CALearningMangementSystem.Models;
using System.Text;

namespace CALearningMangementSystem.Data
{
    internal class InMemoryDatabase
    {
        public static List<User> Users = new List<User>();
        public static List<Models.Course> Courses = new List<Models.Course>();
    }
}
