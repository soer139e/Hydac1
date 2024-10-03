using System;
using System.Threading.Tasks;

namespace HydacProject
{
    
    internal class Program
    {
       public static string filePath = "Visitors.txt";
        static void Main(string[] args)
        {

            
            if (File.Exists(filePath) != true)
            {
                Console.WriteLine("Created Storage file");
                File.Create(filePath);
            }

            FileHandler handler = new FileHandler();
            Visitor visitor = new Visitor();
            VisitorList list = new VisitorList();
            // Tjek om filstien eksistere til Hydac.txt
            // Hvis den ikke eksistere opret en fil og filsti til Hydac.txt
            // Hvis den eksistere, gå videre :)

            // While true

                Menu.StartMenu();

     }

    }
}
 
