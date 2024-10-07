using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    public class Visitor
    {
        public string companyName;
        public string personName;
        public bool safetyBrochurGiven;
        public string responsableForVisitor;
        public DateTime timeOfArrival;
        public DateTime timeOfDeparture;

        // Default Constructor
        public Visitor()
        {

        }
        //Visitor Constructor
        public Visitor(string companyName,string personName,bool safetyBrochurGiven,string responsableForVisitor) 
        {
            this.companyName = companyName;
            this.personName = personName;
            this.safetyBrochurGiven = safetyBrochurGiven;
            this.responsableForVisitor = responsableForVisitor;
            
        }
 
    }
    public class VisitorList
    {
        public List<Visitor> visitors = new List<Visitor> { };

        public int visitorCount = 0;

        public List<Visitor> AddVisitor(Visitor visitor)
        {
            visitor.timeOfArrival = DateTime.Now;
            visitors.Add(visitor); 
            return visitors;

        }
        public void IncrementVisitorCount()
        {
            visitorCount++;
        }
        public List<Visitor> RemoveVisitor(Visitor visitor)
        {
            visitors.Remove(visitor);
            return visitors;
        }

        public void PrintVisitors(VisitorList visitors)
        {
            foreach (Visitor visitor in visitors.visitors)
            {
                Console.WriteLine($"FirmaNavn: {visitor.companyName}, " +
                    $"KundeNavn: {visitor.personName}, " +
                    $"SikkerhedsBrouchur Givet: {visitor.safetyBrochurGiven}, " +
                    $"Ansvarlig for besøgende: {visitor.responsableForVisitor} ");
                
            }
            
        }



    }
    
}
