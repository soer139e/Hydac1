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
            
        

            //Moved menu to Menu.cs
            //Moved login/password til delvis Menu.cs og LoginHandler
            Menu.StartMenu();
            
        } 
            
    }
}
