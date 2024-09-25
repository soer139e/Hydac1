using System.Threading.Tasks;

namespace HydacProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tjek om filstien eksistere til Hydac.txt
            // Hvis den ikke eksistere opret en fil og filsti til Hydac.txt
            // Hvis den eksistere, gå videre :)

            // While true
            while (true)
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
                            Visitor visitor = new Visitor();
                            Console.WriteLine("Indtast hvilket firma du kommer fra:");
                            // console.readline
                            Console.WriteLine("Indtast dit navn:");
                            // console.readline
                            Console.WriteLine("Har du fået udleveret sikkerheds brouchere? Y/N");
                            //if Y bool == true if N bool == false
                            if (Console.ReadLine() == "Y" || Console.ReadLine()=="y")
                            {
                                
                            }
                            else if (Console.ReadLine() == "N" || Console.ReadLine() == "n")
                            {
                                
                            }
                            Console.WriteLine("Hvem er din sikkerhedsansvarlig:");
                            //Console.readline
                            employee.Add
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

                        break;

                }
                // Tast 1 for at tilføje besøgende
                // tobiTheHobi laver 1 
                //Musy laver 2
                //Emil Laver 3
                //søren laver 6


                Console.WriteLine("Skriv besøgendes navn: ");
                Console.ReadLine();
                Console.WriteLine("Skriv besøgendes firma: ");
                Console.ReadLine();

                // Tast 2 for at fjerne besøgende


                // Tast 3 for at se alle aktuelle besøgende


                // Tast 4 for at redigere besøgende


                // Tast 5 for historik over besøgende


                // Tast 6 for at lukke programmet
            }
        }
    }
}
