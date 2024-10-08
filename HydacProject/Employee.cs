using System;
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
        public MoodSmiley moodSmiley = new MoodSmiley();
        public DateTime DateOfDeparture;
        public string password;
        
        //No Arg Consturctor
        public Employee() { }  

        public Employee(string personName,MoodSmiley mood, string password)
        {
            this.DateOfArrival = DateTime.Now;
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
            employee.DateOfArrival = DateTime.Now;
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
        public void PrintEmployee()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"MedarbejderNavn: {employee.personName}, " +
                    $"Humørsmiley status: {employee.moodSmiley.smileyStatus}, " +
                    $"Ankomsttid: {employee.DateOfArrival} " +
                    $"Afgangstid: {employee.DateOfDeparture}");

            }
        }
    }
    public class MoodSmiley
    {
        public bool smileyStatusGiven;
        public string smileyStatus;

        public MoodSmiley()
        {

        }
        public MoodSmiley(bool smileyStatusGiven, string smileyStatus)
        {
            this.smileyStatusGiven = smileyStatusGiven;
            this.smileyStatus = smileyStatus;
        }

        
        
    }
}
