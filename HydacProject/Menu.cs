using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HydacProject
{
    public class Menu
    {
        public static string filePathVisitor = "Visitors.txt";
        public static string filePathEmployee = "Employee.txt";
        public static string filePathVisitorInHouse = "VisitorsInHouse.txt";
        public static string filePathEmployeeInHouse = "EmployeeInHouse.txt";

        public Visitor visitor = new Visitor();
        public VisitorList visitorList = new VisitorList();
        public VisitorList visitorListInHouse = new VisitorList();
        public EmployeeList employeeListInHouse = new EmployeeList();
        public Employee employee = new Employee();
        public EmployeeList employeeList = new EmployeeList();
        public FileHandler handler = new FileHandler();
        public void StartMenu() {
            bool inWhile = true;
            handler.ReadVisitorFromFile(visitorList, filePathVisitor);
            handler.ReadEmployeeFromFile(employeeList, filePathEmployee);
            handler.ReadVisitorFromFile(visitorListInHouse, filePathVisitorInHouse);
            handler.ReadEmployeeFromFile(employeeListInHouse,filePathEmployeeInHouse);
            // Tjek om filstien eksistere til Hydac.txt
            // Hvis den ikke eksistere opret en fil og filsti til Hydac.txt
            // Hvis den eksistere, gå videre :)

            // While true


                Console.Clear();

             

                //Sets Password and Username to Null to initialize the variable
                String username = null;
                String password = null;
                while (inWhile == true)
                {
                Console.WriteLine(" Tryk 1 hvis du er kunde\n");

                Console.WriteLine(" Tryk 2 hvis du er personale\n");

                Console.WriteLine(" Tryk 3 for at luk programmet");
                switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            KundeMenu();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Indtast brugernavn:");
                            String entredUsername = Console.ReadLine();
                            Console.WriteLine("Skriv password");
                            String entredPassword = Console.ReadLine();

                            //Makes an instance of loginHandler and retrives password
                            //TODO make loginHandler retrive list of employees password and usernames
                            LoginHandler loginHandler = new LoginHandler();
                            username = "Emil";//loginHandler.getUsername();
                            password = "Fredberg";//loginHandler.getPassword();
                            if (entredPassword == password && entredUsername == username)
                            {
                                PersonaleMenu();
                            }
                            else if (entredUsername != username)
                            {
                                Console.WriteLine("Brugernavnet er ikke korrekt");
                            }
                            else if (entredPassword != password)
                            {
                                Console.WriteLine("passwordet er ikke korrekt");
                            }
                            else
                                Console.WriteLine("Noget gik galt, prøv igen");
                            break;

                        case "3":
                            Console.WriteLine("Lukker Programmet");
                            inWhile = false;
                            System.Environment.Exit(0);
                            break;



                        default:

                         Console.WriteLine("fejl, tryk 1, 2 eller 3");



                            break;


                    }

                

            }


        }

        public void PersonaleMenu() {
            

            bool inWhile = true;
            while (inWhile == true)
            {

                // Switch


                // Menuvalg
               //Console.Clear();
                Console.WriteLine("Velkommen til Hydac komme/gå system\n");

                Console.WriteLine("Vælg/tast én af nedestående valgmuligheder: \n");

                Console.WriteLine("Tast 1 for at tilføje besøgende");
                Console.WriteLine("Tast 2 for at se alle aktuelle besøgende");
                Console.WriteLine("Tast 3 for at tilføje medarbejder");
                Console.WriteLine("Tast 4 for at fjerne medarbejder");
                Console.WriteLine("Tast 5 for at fjerne besøgende");
                Console.WriteLine("Tast 6 for historik over besøgende");
                Console.WriteLine("Tast 7 for at se medarbejder historik");
                Console.WriteLine("Tast 8 for at se aktuelle med arbejdere");
                Console.WriteLine("Tast 9 for startmenu\n");

                switch (Convert.ToInt32(Console.ReadLine()))

                {
                    case 1:
                        {
                           visitor = new Visitor();

                            Console.Clear();
                            Console.WriteLine("Indtast hvilket firma du kommer fra:");
                            visitor.companyName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Indtast dit navn:");
                            visitor.personName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Har du fået udleveret sikkerheds brouchere? Y/N");
                            //if Y bool == true if N bool == false
                            string choice = Console.ReadLine();
                            if (choice == "Y" || choice == "y")
                            {
                                visitor.safetyBrochurGiven = true;
                            }
                            else if (choice == "N" || choice == "n")
                            {
                                visitor.safetyBrochurGiven = false;
                            }

                            visitor.timeOfArrival = DateTime.Now;
                            visitor.timeOfDeparture = default;

                            Console.Clear();
                            Console.WriteLine("Hvem er din sikkerhedsansvarlig:");
                            visitor.responsableForVisitor = Console.ReadLine();

                            // Add visitor to visitor's vistor list
                            visitorListInHouse.AddVisitor(visitor);
                            
                           
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            visitorListInHouse.PrintVisitors();


                            break;
                        }
                    case 3:
                        employee = new Employee(); 

                        Console.Clear();
                        Console.Write("Indtast medarbejderens navn:");
                        employee.personName = Console.ReadLine();

                        Console.Clear();
                        Console.Write("Indtast det ønskede password");
                        employee.password = Console.ReadLine();

                        employeeList.AddEmployee(employee);
                        handler = new FileHandler();
                        handler.SaveEmployeeToInHouseFile(employeeListInHouse, filePathEmployeeInHouse,employee);
                        break;

                    case 4:
                        
                        Console.Write("Skriv navnet på medarbejder: ");
                        string nameForRemoval = Console.ReadLine();
                        bool nameFound = false;
                        for (int i = 0; i < employeeListInHouse.employeeCount; i++)
                        {
                            if ( nameForRemoval == employeeListInHouse.employees[i].personName)
                            {
                                employeeList.RemoveEmployee(employeeListInHouse.employees[i]);
                                Console.WriteLine("Du har nu fjernet {0}",nameForRemoval);
                                handler.SaveEmployeeToFile(employeeList, filePathEmployee, employeeListInHouse.employees[i]);
                                nameFound = true;
                            }
                        }
                        if(nameFound != true)
                        {
                            Console.WriteLine("Fandt ikke medarbejderen, sikrer at navnet er indtastet korrekt.");
                        }
                        

                        break;

                    case 5:

                        //Tast 5 for at fjerne besøgende
                        Console.Write("Skriv navnet på besøgende: ");
                        nameForRemoval = Console.ReadLine();
                        nameFound = false;
                        for (int i = 0; i < visitorListInHouse.visitorCount; i++)
                        {
                            if (nameForRemoval == visitorListInHouse.visitors[i].personName)
                            {
                                visitorListInHouse.RemoveVisitor(visitorListInHouse.visitors[i]);
                                Console.WriteLine("Du har nu fjernet {0}", nameForRemoval);
                                handler.SaveVisitorToFile(visitorList, filePathVisitor, visitorListInHouse.visitors[i]);
                                nameFound = true;
                            }
                        }
                        if (nameFound != true)
                        {
                            Console.WriteLine("Fandt ikke den besøgende, sikrer at navnet er indtastet korrekt.");
                        }


                        break;
                    case 6:
                        visitorList.PrintVisitors();
                        break;
                      
                    case 7:
                        //Historik
                        employeeList.PrintEmployee();
                        break;
                    case 8:
                        // Aktuelle
                        employeeListInHouse.PrintEmployee();
                        break;
                    case 9:
                        inWhile = false;
                        StartMenu();
                        break;

                }

            }
            }

        public void KundeMenu() {
           // FileHandler handler = new FileHandler();
            //Visitor visitor = new Visitor();
            //VisitorList list = new VisitorList();
            bool inWhile2 = true;
            while (inWhile2 == true)
            {


                Console.WriteLine("Velkommen til Hydac komme/gå system\n");

                Console.WriteLine("Vælg/tast én af nedestående valgmuligheder: \n");

                Console.WriteLine("Tast 1 for at tilføje besøgende\n");

                Console.WriteLine("Tast 2 for at tjekke en besøgende ud");
                
                Console.WriteLine("Tast 3 for startmenu");


                switch (Convert.ToInt32(Console.ReadLine()))

                {
                    case 1:
                        {
                            visitor = new Visitor();
                            Console.Clear();
                            Console.WriteLine("Indtast hvilket firma du kommer fra:");
                            visitor.companyName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Indtast dit navn:");
                            visitor.personName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Har du fået udleveret sikkerheds brouchere? Y/N");
                            //if Y bool == true if N bool == false
                            string choice = Console.ReadLine();
                            if (choice == "Y" || choice == "y")
                            {
                                visitor.safetyBrochurGiven = true;
                            }
                            else if (choice == "N" || choice == "n")
                            {
                                visitor.safetyBrochurGiven = false;
                            }
                            Console.Clear();
                            Console.WriteLine("Hvem er din sikkerhedsansvarlig:");
                            visitor.responsableForVisitor = Console.ReadLine();

                            // Add visitor to visitor's vistor list
                            visitorListInHouse.AddVisitor(visitor);
                            
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Skriv navnet på besøgende: ");
                            string nameForRemoval = Console.ReadLine();
                            bool nameFound = false;
                            for (int i = 0; i < visitorListInHouse.visitorCount; i++)
                            {
                                if (nameForRemoval == visitorListInHouse.visitors[i].personName)
                                {
                                    visitorListInHouse.RemoveVisitor(visitorListInHouse.visitors[i]);
                                    Console.WriteLine("Du har nu fjernet {0}", nameForRemoval);
                                    handler.SaveVisitorToFile(visitorList,filePathVisitor, visitorListInHouse.visitors[i]);
                                    nameFound = true;
                                }
                            }
                            if (nameFound != true)
                            {
                                Console.WriteLine("Fandt ikke den besøgende, sikrer at navnet er indtastet korrekt.");
                            }
                            
                            break;
                        }
                    case 3:
                        {
                            inWhile2 = false;
                            StartMenu();
                            break;
                        }




                }
            } 
            
        }
    }
}
