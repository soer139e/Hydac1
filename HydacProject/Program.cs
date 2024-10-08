using System;
using System.Threading.Tasks;

namespace HydacProject
{
    
    internal class Program
    {
       public static string filePathVisitor = "Visitors.txt";
       public static string filePathEmloyee = "Employee.txt";
        public static string filePathVisitorInHouse = "VisitorsInHouse.txt";
        public static string filePathEmployeeInHouse = "EmployeeInHouse.txt";
        static void Main(string[] args)
        {

            if (File.Exists(filePathVisitor) != true)
            {
                Console.WriteLine("Created Storage file for Vistors");
                using FileStream fs = File.Create(filePathVisitor);
            }
            if (File.Exists(filePathEmloyee) != true) {
               
                Console.WriteLine("Created Storage file for Employees");
                using FileStream fs = File.Create(filePathEmloyee);
                
            }
            if (File.Exists(filePathEmployeeInHouse) != true)
            {
                Console.WriteLine("Created Storage file for EmployeesInHouse");
                using FileStream fs = File.Create(filePathEmployeeInHouse);
            }
            if (File.Exists(filePathVisitorInHouse) != true)
            {
                Console.WriteLine("Created Storage file for VisitorInHouse");
                using FileStream fs = File.Create(filePathVisitorInHouse);
            }

            
            Menu menu = new Menu();

            menu.StartMenu();

     }

    }
}
 
