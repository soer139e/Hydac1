using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    public class Employee
    {
        public string personName;
        public DateTime DateOfArrival;
        public MoodSmiley moodSmiley;
        public DateTime DateOfDeparture;
        public string password;
        
        //No Arg Consturctor
        public Employee() { }  

        public Employee(string personName,MoodSmiley mood)
        {
            this.DateOfDeparture = DateTime.Now;
            this.personName = personName;
            this.moodSmiley = mood;
        }
    }
    public class EmployeeList
    {
        public List<Employee> employees;
        public int employeeCount;
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
