using System;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visitor visitor = new Visitor();
            VisitorList list = new VisitorList();
            // Tjek om filstien eksistere til Hydac.txt
            // Hvis den ikke eksistere opret en fil og filsti til Hydac.txt
            // Hvis den eksistere, gå videre :)

            // While true
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
                Console.WriteLine("Tast 6 for at lukke programmet\n");

                switch(Convert.ToInt32(Console.ReadLine()))

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
                            if (choice == "Y" || choice=="y")
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
                            break;
                        }
                        case 3:

                        break;

                        case 4:

                        break;

                        case 5:

                        break;

                        case 6:
                        inWhile = false;
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
    }
}
