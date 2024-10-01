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
        
        public List<Visitor> AddVisitor(Visitor visitor)
        {
            visitors.Add(visitor);
            return visitors;
            
        }

        public List<Visitor> RemoveVisitor(Visitor visitor)
        {
            visitors.Remove(visitor);
            return visitors;
        }

        public List<Visitor> PrintVisitor(Visitor visitor)
        {
            foreach (Visitor visitor2 in visitors)
            {
                Console.WriteLine(visitor2);
                
            }
            return visitors;
        }



    }
    
}
