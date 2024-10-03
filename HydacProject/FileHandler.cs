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
        public static void SaveVisitorToFile(Visitor visitor, string filePath)
        {
            //Gets StreamWriter library and creates a instances of it that will write to the specified .txt file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                
                    // Writes the properties in Visitor separated by a comma
                    writer.WriteLine($"{visitor.companyName} ,{visitor.personName},{visitor.safetyBrochurGiven},{visitor.responsableForVisitor}");

                

            }
        }
        //ReadVisitorFromFile will read a .txt file and add all instances of Visitors to the VisitorList
        public void ReadVisitorFromFile(string filepath)
        {
            string[] lineSplit;
            string line;
            // Uses the StreamReader library and creates an instances of StreamReader that will read the specified .txt file
            using (StreamReader reader = new StreamReader(filepath))
            {
                //Checks if the file is empty
                line = reader.ReadLine();
                //Loops through the .txt file until all is read
                while(line != null)
                {
                    lineSplit = line.Split(new char[] { ',' });
                    visitor.companyName = lineSplit[0];
                    visitor.personName = lineSplit[1];
                    visitor.safetyBrochurGiven = Convert.ToBoolean(lineSplit[2]);
                    visitor.responsableForVisitor = lineSplit[3];

                    line = reader.ReadLine();
                }
            }


        }
    }
}
