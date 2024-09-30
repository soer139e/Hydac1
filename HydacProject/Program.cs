using System;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }

        static void StartMenu()
        {

            // Tjek om filstien eksistere til Hydac.txt
            // Hvis den ikke eksistere opret en fil og filsti til Hydac.txt
            // Hvis den eksistere, gå videre :)

            // While true


            {
                Console.Clear();
                Console.WriteLine(" Tryk 1 hvis du er kunde\n");

                Console.WriteLine(" Tryk 2 hvis du er personale\n");

                Console.WriteLine(" Tryk 3 for at luk programmet");

                string input = Console.ReadLine();
                Console.Clear();

                bool inWhile = true;
                int pass = 6969;
                while (inWhile)
                {
                    switch (input)
                    {
                        case "1":
                            KundeMenu();

                            break;

                        case "2":
                            Console.WriteLine("Skriv password");
                            int password = Convert.ToInt32(Console.ReadLine());
                            if (password == pass)
                            {
                                PersonaleMenu();

                            }

                            else
                                Console.WriteLine("Forkert kodeord, prøv igen");
                            break;

                        case "3":

                            Console.WriteLine("Lukker programmet");
                            inWhile = false;
                            break;



                        default:

                            Console.WriteLine("fejl, tryk 1 eller 2\n");
                            


                            break;


                    }

                }

            }


        }
        static void PersonaleMenu()



        {
            Visitor visitor = new Visitor();
            VisitorList list = new VisitorList();
           
            bool inWhile = true;
            while (inWhile == true)
            {

                // Switch


                // Menuvalg
                Console.WriteLine("Velkommen til Hydac komme/gå system\n");

                Console.WriteLine("Vælg/tast én af nedestående valgmuligheder: \n");

                Console.WriteLine("Tast 1 for at tilføje besøgende");
                Console.WriteLine("Tast 2 for at fjerne besøgende");
                Console.WriteLine("Tast 3 for at se alle aktuelle besøgende");
                Console.WriteLine("Tast 4 for at redigere besøgende");
                Console.WriteLine("Tast 5 for historik over besøgende");
                Console.WriteLine("Tast 6 for startmenu\n");

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
                            list.AddVisitor(visitor);
                            break;
                        }
                    case 2:
                        Console.Clear();
                        {
                            list.PrintVisitor(visitor);
                            

                            break;
                        }
                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:




                        break;

                    case 6:
                        StartMenu();
                        break;

                }
                // Tast 1 for at tilføje besøgende
                // tobiTheHobi laver 1 
                //Musy laver 2
                //Emil Laver 3
                //søren laver 6




                // Tast 2 for at fjerne besøgende


                // Tast 3 for at se alle aktuelle besøgende


                // Tast 4 for at redigere besøgende


                // Tast 5 for historik over besøgende


                // Tast 6 for at lukke programmet
            }
        }
        static void KundeMenu()
        {
            Visitor visitor = new Visitor();
            VisitorList list = new VisitorList();
            bool inWhile = true;
            while (inWhile == true)
            {

                // Switch


                // Menuvalg
                Console.WriteLine("Velkommen til Hydac komme/gå system\n");

                Console.WriteLine("Vælg/tast én af nedestående valgmuligheder: \n");

                Console.WriteLine("Tast 1 for at tilføje besøgende\n");

                Console.WriteLine("Tast 2 for startmenu");


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
                            list.AddVisitor(visitor);
                            break;
                        }


                    case 2:
                        {

                            StartMenu();

                            break;
                        }




                }
            }
        }

        


        

        
    }
}
