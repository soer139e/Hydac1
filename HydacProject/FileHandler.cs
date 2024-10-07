﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HydacProject
{
    public class FileHandler
    {
        
        // Creates new Visitor
        Visitor visitor = new Visitor();
        // Creates new Employee
        Employee employee = new Employee();
         
        //SaveVisitorToFile saves the Visitor list to a .txt file
        //It accepts a Visitorlist and a filePath
        public void SaveVisitorToFile(VisitorList visitorList,string filePath,Visitor visitor)
        {
            //Gets StreamWriter library and creates a instances of it that will write to the specified .txt file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                visitor.timeOfDeparture = DateTime.Now;

                    // Writes the properties in Visitor separated by a comma
                    // threw an index exception because of visitorCount++ before return in AddVisitor.
                    // Made a method to increment after the visitor hans been writen.
                    writer.WriteLine(
                        $"{visitor.companyName}," +
                        $"{visitor.personName}," +
                        $"{visitor.safetyBrochurGiven}," +
                        $"{visitor.responsableForVisitor}," +
                        $"{visitor.timeOfArrival}," +
                        $"{visitor.timeOfDeparture}");

                

            }
            visitorList.IncrementVisitorCount();
        }
        //ReadVisitorFromFile will read a .txt file and add all instances of Visitors to the VisitorList

        public void ReadVisitorFromFile(VisitorList visitorlist, string filepath)
        {
            string[] lineSplit;
            string line;
            // Uses the StreamReader library and creates an instances of StreamReader that will read the specified .txt file
            using (StreamReader reader = new StreamReader(filepath))
            {
                //Checks if the file is empty
                line = reader.ReadLine();
                //Loops through the .txt file until all is read
                while (line != null)
                {
                    // Gets the current line and splits it at every ',' turning it into a string array
                    lineSplit = line.Split(new char[] { ',' });
                    // Assigns visitor the read data
                    visitor.companyName = lineSplit[0];
                    visitor.personName = lineSplit[1];
                    visitor.safetyBrochurGiven = Convert.ToBoolean(lineSplit[2]);
                    visitor.responsableForVisitor = lineSplit[3];
                    // adds the visitor to a visitor list
                    visitorlist.visitors.Add(visitor);
                    visitorlist.IncrementVisitorCount();
                    visitor = new Visitor();
                    line = reader.ReadLine();
                    if (line == "")
                    {
                        line = null;
                    }
                }
            }


        }
        public void ReadEmployeeFromFile(EmployeeList employeeList, string filepath)
        {
            string[] lineSplit;
            string line;
            // Uses the StreamReader library and creates an instances of StreamReader that will read the specified .txt file
            using (StreamReader reader = new StreamReader(filepath))
            {
                //Checks if the file is empty
                line = reader.ReadLine();
                //Loops through the .txt file until all is read
                while (line != null)
                {
                    // Gets the current line and splits it at every ',' turning it into a string array
                    lineSplit = line.Split(new char[] { ',' });
                    // Assigns employee the read data
                    employee.personName = lineSplit[0];
                    employee.password = lineSplit[1];
                    //employee.moodSmiley = lineSplit[2];
                    employee.DateOfArrival = Convert.ToDateTime(lineSplit[3]);
                    employee.DateOfDeparture = Convert.ToDateTime(lineSplit[4]);
                    // adds the employee to a employee list
                    employeeList.employees.Add(employee);
                    employeeList.IncrementEmployeeCount();
                    employee = new Employee();
                    line = reader.ReadLine();
                    if(line == "")
                    {
                        line = null;
                    }
                }
            }
        }
        public void SaveEmployeeToFile(EmployeeList employeeList, string filePath, Employee employee)
        {
            //Gets StreamWriter library and creates a instances of it that will write to the specified .txt file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                employee.DateOfDeparture = DateTime.Now;


                // Writes the properties in Employee separated by a comma

                writer.WriteLine($"{employee.personName}," +
                    $"{employee.password}," +
                    $"{employee.moodSmiley}," +
                    $"{employee.DateOfArrival}," +
                    $"{employee.DateOfDeparture},");

                employeeList.IncrementEmployeeCount();

            }
        }
        public void SaveEmployeeToInHouseFile(EmployeeList employeeListInHouse, string filePath, Employee employee)
        {
            //Gets StreamWriter library and creates a instances of it that will write to the specified .txt file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                // Writes the properties in Employee separated by a comma

                writer.WriteLine($"{employee.personName}," +
                    $"{employee.password}," +
                    $"{employee.moodSmiley}," +
                    $"{employee.DateOfArrival},");

            }
                employeeListInHouse.IncrementEmployeeCount();

        }
            
    }
}

