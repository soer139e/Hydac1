using System;
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
         
        //SaveVisitorToFile saves the Visitor list to a .txt file
        //It accepts a Visitorlist and a filePath
        public void SaveVisitorToFile(VisitorList visitorList, string filePath)
        {
            //Gets StreamWriter library and creates a instances of it that will write to the specified .txt file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {



                // Writes the properties in Visitor separated by a comma

                writer.WriteLine($"{visitorList.visitors[visitorList.visitorCount].companyName}," +
                    $"{visitorList.visitors[visitorList.visitorCount].personName}," +
                    $"{visitorList.visitors[visitorList.visitorCount].safetyBrochurGiven}," +
                    $"{visitorList.visitors[visitorList.visitorCount].responsableForVisitor}," +
                    $"{visitorList.visitors[visitorList.visitorCount].timeOfArrival}," +
                    $"{visitorList.visitors[visitorList.visitorCount].timeOfDeparture = DateTime.Now}");



            }
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
                    visitorlist.visitors[visitorlist.visitorCount] = visitor;

                    line = reader.ReadLine();
                }
            }


        }
        public void ReadEmployeeFromFile(VisitorList visitorlist, string filepath)
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
                    visitorlist.visitors[visitorlist.visitorCount] = visitor;

                    line = reader.ReadLine();
                }
            }
        }
        public void SaveEmployeeToFile(VisitorList visitorList, string filePath)
        {
            //Gets StreamWriter library and creates a instances of it that will write to the specified .txt file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {



                // Writes the properties in Visitor separated by a comma

                writer.WriteLine($"{visitorList.visitors[visitorList.visitorCount].companyName}," +
                    $"{visitorList.visitors[visitorList.visitorCount].personName}," +
                    $"{visitorList.visitors[visitorList.visitorCount].safetyBrochurGiven}," +
                    $"{visitorList.visitors[visitorList.visitorCount].responsableForVisitor}," +
                    $"{visitorList.visitors[visitorList.visitorCount].timeOfArrival}," +
                    $"{visitorList.visitors[visitorList.visitorCount].timeOfDeparture = DateTime.Now}");



            }
        }
    }
}
