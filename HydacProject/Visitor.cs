using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Visitor
    {
        public string companyName;
        public string personName;
        public bool safetyBrochurGiven;
        public string responsableForVisitor;
        public List<Visitor> visitors = new List<Visitor> { };
        public Visitor(string companyName,string personName,bool safetyBrochurGiven,string responsableForVisitor) 
        {
            this.companyName = companyName;
            this.personName = personName;
            this.safetyBrochurGiven = safetyBrochurGiven;
            this.responsableForVisitor = responsableForVisitor;
        }
        public List<Visitor> AddVisitor(Visitor visitor)
        {
            visitors.Add(visitor);
            return visitors;
        }
    }
}
