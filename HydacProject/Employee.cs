﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

        public Employee(string personName,MoodSmiley mood, string password)
        {
            this.DateOfDeparture = DateTime.Now;
            this.personName = personName;
            this.moodSmiley = mood;
            this.password = password;
        }
    }
    public class EmployeeList
    {
        public List<Employee> employees = new List<Employee> { };
        public int employeeCount = 0;

        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;

        }
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            employeeCount--;
        }
        public void IncrementEmployeeCount()
        {
            employeeCount++;
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
