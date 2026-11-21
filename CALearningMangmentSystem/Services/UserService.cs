using System;
using System.Collections.Generic;
using System.Text;
using CALearningMangementSystem.Models;
using CALearningMangementSystem.Data;

namespace CALearningMangementSystem.Services
{
    internal class UserService
    {
        private static void ValidatePhoneNotExists(string phone)
        {
            if (InMemoryDatabase.Users.Exists(u => u.PhoneNumber == phone))
            {
                throw new InvalidOperationException("A user with this phone number already exists.");
            }
        }
        // Method to register a new user
        public static void RegisterStudent(string? name, string? phone, string? password)
        {
            ValidatePhoneNotExists(phone);
            var user = new Student(name, phone, password);
            InMemoryDatabase.Users.Add(user);
        }
        public static void RegisterInstructor(string? name, string? phone, string? password)
        {

            ValidatePhoneNotExists(phone);
            var user = new Instructor(name, phone, password);
            InMemoryDatabase.Users.Add(user);
        }
        // Method to authenticate a user
        public static User Login(string? phone, string? password)
        {
            var user = InMemoryDatabase.Users.Find(u => u.PhoneNumber == phone && u.Password == password);
            if (user == null)
            {
                throw new InvalidOperationException("Invalid phone number or password.");
            }
            return user;
        }
    }
}
