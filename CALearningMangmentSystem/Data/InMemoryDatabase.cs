using System;
using System.Collections.Generic;
using System.Text;

namespace CALearningMangementSystem.Data
{
    internal class InMemoryDatabase
    {
        public static List<Models.User> Users = new List<Models.User>();
        public static List<Models.Course> Courses = new List<Models.Course>();
    }
}
