using System;
using System.Collections.Generic;
using System.Text;

namespace CALearningMangementSystem.Models
{
    internal class Course
    {
        private decimal _price;
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price {
            get => _price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be negative or zero.");
                }
                _price = value;
            }
                }
        public string InstructorId { get; set; }

        public List<Lesson> Lessons { get; set; }

        public Course(string id, string title, string description, decimal price, string instructorId)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price; // Use the private setter to validate the price
            InstructorId = instructorId;
            Lessons = new List<Lesson>();
        }


        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }
    }
}
