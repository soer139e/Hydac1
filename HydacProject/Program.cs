using System;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = "Visitors.txt";
            if (File.Exists(filePath) != true)
            {
                Console.WriteLine("Created Storage file");
                File.Create(filePath);
            }


            Visitor visitor = new Visitor();
            VisitorList list = new VisitorList();
            // Tjek om filstien eksistere til Hydac.txt
            // Hvis den ikke eksistere opret en fil og filsti til Hydac.txt
            // Hvis den eksistere, gå videre :)

            // While true
            bool inWhile = true;
            while (inWhile == true)
            {
                

                

               
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

                
            }
        }

            //Moved menu to Menu.cs
            //Moved login/password til delvis Menu.cs og LoginHandler
            Menu.StartMenu();
            
        } 
            
    }
}
