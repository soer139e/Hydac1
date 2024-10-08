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
                            username = "admin";//loginHandler.getUsername();
                            password = "admin";//loginHandler.getPassword();
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
                



                // Menuvalg

                Console.WriteLine("Velkommen til Hydac komme/gå system\n");

                Console.WriteLine("Vælg/tast én af nedestående valgmuligheder: \n");

                Console.WriteLine("Tast 1 for at tilføje besøgende");
                Console.WriteLine("Tast 2 for at tilføje medarbejder");
                Console.WriteLine("Tast 3 for at fjerne besøgende");
                Console.WriteLine("Tast 4 for at fjerne medarbejder");
                Console.WriteLine("Tast 5 for at se aktuelle besøgende");
                Console.WriteLine("Tast 6 for at se aktuelle medarbejdere");
                Console.WriteLine("Tast 7 for at se historik over besøgende");
                Console.WriteLine("Tast 8 for at se historik over medarbejder");
                Console.WriteLine("Tast 9 for startmenu\n");

                switch (Convert.ToInt32(Console.ReadLine()))

                {
                    case 1:
                        {
                            //Adds new visitor
                           visitor = new Visitor();

                            Console.Clear();
                            Console.WriteLine("Indtast hvilket firma du kommer fra:");
                            visitor.companyName = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Indtast dit fulde navn:");
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
                            handler.SaveVisitorToFile(visitorListInHouse, filePathVisitorInHouse, visitor);
                            Console.Clear();

                            Console.WriteLine("Den besøgende blev tilføjet!\n");
                           
                            break;
                        }
                    case 2:
                        {
                            //Adds new Employee
                            employee = new Employee();
                            handler = new FileHandler();

                            Console.Clear();
                            Console.Write("Indtast medarbejderens fulde navn: ");
                            employee.personName = Console.ReadLine();

                            Console.Clear();
                            Console.Write("Indtast det ønskede password: ");
                            employee.password = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Hvordan er humør smileyen for idag?: ");

                            employee.moodSmiley.smileyStatus = Console.ReadLine();
                            employee.moodSmiley.smileyStatusGiven = true;
                            employee.DateOfDeparture = DateTime.Now;
                            employeeListInHouse.AddEmployee(employee);
                            handler.SaveEmployeeToInHouseFile(employeeListInHouse, filePathEmployeeInHouse, employee);

                            Console.Clear();
                            Console.WriteLine("Medarbejderen blev tilføjet!\n");

                            break;
                        }
                    case 3:
                        //Removes Visitor
                        Console.Write("Skriv navnet på den besøgende: ");
                        string nameForRemoval = Console.ReadLine();
                        handler.ReadVisitorFromFile(visitorListInHouse, filePathVisitorInHouse);
                        bool nameFound = false;
                        for (int i = 0; i < visitorListInHouse.visitors.Count; i++)
                        {
                            if (nameForRemoval == visitorListInHouse.visitors[i].personName)
                            {

                                handler.RemoveVisitorFromFile(filePathVisitorInHouse, visitorListInHouse.visitors[i]);
                                nameFound = true;
                                visitorList.RemoveVisitor(visitorListInHouse.visitors[i]);
                                Console.WriteLine(" ");
                                Console.WriteLine("Du har nu fjernet {0}", nameForRemoval);
                                Console.WriteLine(" ");
                                break;
                            }
                        }
                        if (nameFound != true)
                        {
                            Console.WriteLine("Fandt ikke den besøgende, sikrer at navnet er indtastet korrekt.");
                        }

                        break;

                    case 4:
                        //Removes Employee
                        Console.Write("Skriv navnet på medarbejder: ");
                        nameForRemoval = Console.ReadLine();
                        handler.ReadEmployeeFromFile(employeeListInHouse, filePathEmployeeInHouse);
                        nameFound = false;
                        for (int i = 0; i < employeeListInHouse.employees.Count; i++)
                        {
                            if (nameForRemoval == employeeListInHouse.employees[i].personName)
                            {   
                                
                                handler.RemoveEmployeeFromFile(filePathEmployeeInHouse, employeeListInHouse.employees[i]);
                                nameFound = true;
                                employeeList.RemoveEmployee(employeeListInHouse.employees[i]);
                                Console.WriteLine(" ");
                                Console.WriteLine("Du har nu fjernet {0}", nameForRemoval);
                                Console.WriteLine(" ");
                                break;
                            }
                        }
                        if (nameFound != true)
                        {
                            Console.WriteLine("Fandt ikke medarbejderen, sikrer at navnet er indtastet korrekt.");
                        }
                        

                        break;

                    case 5:
                        //Shows List of current visitors
                        Console.Clear();
                        Console.WriteLine("Her er listen over aktuelle besøgende:\n");
                        visitorListInHouse = new VisitorList();
                        handler.ReadVisitorFromFile(visitorListInHouse, filePathVisitorInHouse);
                        visitorListInHouse.PrintVisitors();
                        Console.WriteLine("");
                        if(visitorListInHouse.visitorCount == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Listen for aktuelle besøgende er tom.\n");
                            Console.WriteLine("Du sendes tilbage til menu:\n");
                        }
                        
                        break;
                    case 6:
                        //Shows list of current employees
                        Console.Clear();
                        Console.WriteLine("Her er listen over aktuelle medarbejdere:\n");
                        employeeListInHouse = new EmployeeList();
                        handler.ReadEmployeeFromFile(employeeListInHouse, filePathEmployeeInHouse);
                        employeeListInHouse.PrintEmployee();
                        Console.WriteLine("");
                        if (employeeListInHouse.employeeCount == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Listen for aktuelle medarbejdere er tom.\n");
                            Console.WriteLine("Du sendes tilbage til menu:\n");
                        }
                        break;
                      
                    case 7:
                        //Shows list of history of visitors
                        visitorList.PrintVisitors();
                        if (visitorList.visitorCount == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Listen for besøgende historik er tom.\n");
                            Console.WriteLine("Du sendes tilbage til menu:\n");
                        }
                        break;
                    case 8:
                        //Shows list of history of employees
                        employeeList.PrintEmployee();

                        if (employeeList.employeeCount == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Listen Medarbejder Historik er tom.\n");
                            Console.WriteLine("Du sendes tilbage til menu:\n");
                        }
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
