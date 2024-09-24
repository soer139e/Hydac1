using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Visoter
    {
        public string companyName;
        public string personName;
        public bool safetyBrochurGiven;
        public string responsableForVisitor;

        public Visoter(string companyName,string personName,bool safetyBrochurGiven,string responsableForVisitor) 
        { 
            this.companyName = companyName;
            this.personName = personName;
            this.safetyBrochurGiven = safetyBrochurGiven;
            this.responsableForVisitor = responsableForVisitor;
        }
        public Visitor[] addVisitor()
        {

        }
    }
}
