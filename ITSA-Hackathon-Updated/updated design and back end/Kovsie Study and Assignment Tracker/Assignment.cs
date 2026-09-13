using System;
using System.Runtime.Serialization;

namespace Kovsie_Study_and_Assignment_Tracker
{
    /// <summary>
    /// Represents a single assignment belonging to a module.
    /// This is the custom class used instead of parallel arrays / loose variables.
    /// </summary>
    [DataContract]
    public class Assignment
    {
        [DataMember]
        public string Module { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public DateTime DueDate { get; set; }

        [DataMember]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// True when the assignment has not been completed and its due date has passed.
        /// </summary>
        public bool IsOverdue
        {
            get { return !IsCompleted && DueDate.Date < DateTime.Today; }
        }

        /// <summary>
        /// Whole days between today and the due date. Negative once the assignment is overdue.
        /// </summary>
        public int DaysRemaining
        {
            get { return (DueDate.Date - DateTime.Today).Days; }
        }

        public string StatusText
        {
            get
            {
                if (IsCompleted)
                {
                    return "Completed";
                }

                int days = DaysRemaining;
                if (days < 0)
                {
                    int daysOverdue = -days;
                    return string.Format("Overdue by {0} day{1}", daysOverdue, daysOverdue == 1 ? "" : "s");
                }
                if (days == 0)
                {
                    return "Due today";
                }
                return string.Format("Due in {0} day{1}", days, days == 1 ? "" : "s");
            }
        }

        public Assignment()
        {
            Module = string.Empty;
            Title = string.Empty;
        }

        public Assignment(string module, string title, DateTime dueDate)
        {
            Module = module;
            Title = title;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public string GetDetailsText()
        {
            return string.Format(
                "Module: {0}\nAssignment: {1}\nDue date: {2:dddd, dd MMMM yyyy}\nStatus: {3}",
                Module, Title, DueDate, StatusText);
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} ({2:dd MMM yyyy}) - {3}", Module, Title, DueDate, StatusText);
        }
    }
}
