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
        public int visitorCount = 0;

        public List<Visitor> AddVisitor(Visitor visitor)
        {
            visitors.Add(visitor);
            visitorCount++;
            return visitors;
        }
    }
}
