using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    partial class UI
    {
        private readonly string welcome = "-------------------------------------------\n" +
                                 "---------Auther Administrator 2000---------\n" +
                                 "-------------------------------------------\n\n";

        private readonly string mainMenu = "(1) Show All Authers\n" +
                                  "(2) Find Auther\n" +
                                  "(3) Add new Auther\n" +
                                  "(4) Update existing Author\n" +
                                  "(Q) Quit";

        private readonly string findAuther = "(1) Find by ID\n" +
                                    "(2) Find by Name\n" +
                                    "(Q) Back";
   


        public void ShowMenu()
        {
            Console.WriteLine(welcome + mainMenu);
        }

        public void ShowFindAuther()
        {
            Console.WriteLine(welcome + findAuther);
        }

        public void ShowAutherByNameMenu()
        {
            
        }


        public void NotFound(string Item)
        {
            Console.WriteLine($"{Item} could not found");
        }

        public void Found(int count)
        {
            Console.WriteLine($"Found {count}");
        }

        public void NewAuther()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---------Add a new auther---------");
            Console.WriteLine("----------------------------------");
        }

        public void ErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
