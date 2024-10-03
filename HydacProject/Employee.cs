using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Employee
    {
        public string personName;
        public DateTime DateOfArrival;
        public MoodSmiley moodSmiley;
        public DateTime DateOfDeparture;

        public Employee(DateTime DateOfArrival, DateTime DateOfDeparture)
        {
            this.DateOfDeparture = DateOfDeparture;
            this.DateOfArrival = DateOfArrival;
        }
    }
    public class MoodSmiley
    {
        public bool smileyStatusGiven;
        public string smileyStatus;

        public MoodSmiley(bool smileyStatusGiven, string smileyStatus)
        {
            this.smileyStatusGiven = smileyStatusGiven;
            this.smileyStatus = smileyStatus;
        }
    }
}
