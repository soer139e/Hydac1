using System;
using System.Threading.Tasks;

namespace HydacProject
{
    
    internal class Program
    {
       public static string filePathVisitor = "Visitors.txt";
       public static string filePathEmloyee = "Employee.txt";
        static void Main(string[] args)
        {

            
            if (File.Exists(filePathVisitor) != true)
            {
                Console.WriteLine("Created Storage file for Vistors");
                File.Create(filePathVisitor);
            }
            if (File.Exists(filePathEmloyee) != true) {
                Console.WriteLine("Created Storage file for Employees");
                File.Create(filePathEmloyee);
            }

            //Er jeg blind, eller bruges de her objekter til noget?
            FileHandler handler = new FileHandler();
            Visitor visitor = new Visitor();
            VisitorList list = new VisitorList();


                Menu.StartMenu();

     }

    }
}
 
