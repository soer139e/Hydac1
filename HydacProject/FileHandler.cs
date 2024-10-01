using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HydacProject
{
    class FileHandler
    {
        static void SaveToFile(List<Visitor> VisitorList, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var Visitor in VisitorList)
                {
                    // Write the properties separated by a comma
                    writer.WriteLine($"{Visitor.companyName},{Visitor.personName},{Visitor.safetyBrochurGiven},{Visitor.responsableForVisitor}");
                }
            }
        }
        public void ReadFromFile(string filepath)
        {
            string line;
            using (StreamWriter reader = new StreamWriter(filepath))
            {
                line = reader.;
                while(line != null)
                {
                    line =
                }
            }


        }
    }
}
