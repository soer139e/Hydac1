using System;
using System.Threading.Tasks;

namespace HydacProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Moved menu to Menu.cs
            //Moved login/password til delvis Menu.cs og LoginHandler
            Menu.StartMenu();
            
        } 
    }
}
