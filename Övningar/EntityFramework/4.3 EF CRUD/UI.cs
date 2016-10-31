using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    partial class Ui
    {
        private readonly string welcome = "-------------------------------------------\n" +
                                 "---------Auther Administrator 2000---------\n" +
                                 "-------------------------------------------\n\n";

        private readonly string mainMenu = "(1) Show All Authers\n" +
                                  "(2) Find Auther\n" +
                                  "(3) Add new Auther\n" +
                                  "(4) Update existing Author\n" +
                                  "(Q) Quit";

        private readonly string findAutherMenu = "(1) Find by ID\n" +
                                                 "(2) Find by Name\n" +
                                                 "(Q) Back";



        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(welcome + mainMenu);
        }

        public void ShowFindAuther()
        {
            Console.Clear();
            Console.WriteLine(welcome + findAutherMenu);
        }

        public void NotFound(string item)
        {
            Console.WriteLine($"{item} could not found");
            Console.ReadKey();
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
            Console.ReadKey();
        }

        public void Print<T>(T t)
        {
            try
            {
                Console.WriteLine(t);
                Console.ReadKey();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void PrintList<T>(List<T> list)
        {
            try
            {

                list.ForEach(x => Console.WriteLine(x));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
