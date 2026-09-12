using System;
using System.Runtime.Serialization;

namespace Kovsie_Study_and_Assignment_Tracker
{
    [DataContract]
    public class Assignment
    {
        [DataMember]
        public string Module { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime DueDate { get; set; }
        [DataMember]
        public bool IsCompleted { get; set; }

        public bool IsOverdue
        {
            get
            {
                return !IsCompleted && DueDate.Date < DateTime.Today;
            }
        }

        public Assignment()
        {
            Module = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
        }

        public Assignment(string module, string title, string description, DateTime dueDate)
        {
            Module = module;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Due Date: {0}", DueDate.ToShortDateString());
            Console.WriteLine("Completed: {0}", IsCompleted);
        }

        public override string ToString()
        {
            string statusText = IsCompleted ? " - Completed" : (IsOverdue ? " - Overdue" : " - Upcoming");
            return string.Format("{0} | {1} ({2:dd MMM yyyy}){3}", Module, Title, DueDate, statusText);
        }
    }
}
