using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovsie_Study_and_Assignment_Tracker
{
    internal class Assignment
    {
        // Properties
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        // Constructor
        public Assignment(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }
        // Method to mark the assignment as completed
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        // Method to display assignment details
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Due Date: {DueDate.ToShortDateString()}");
            Console.WriteLine($"Completed: {IsCompleted}");
        }
    }
}
