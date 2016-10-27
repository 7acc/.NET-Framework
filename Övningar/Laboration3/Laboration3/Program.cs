using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extentions;

namespace Laboration3
{
    class Program
    {
        public string MenuText = "(E) 3.1 - 3.2 Extentionmethods\n" +
                                 "(L) 3.3 Linq" +
                                 "(D) 3.4 Linq And Lambda";
        public ConsoleKey Selected;

        public void PrintMenu()
        {
            Console.Write(MenuText);

        }

        public void UserSelect()
        {

            Selected = Console.ReadKey(true).Key;          
           
        }
        public void Navigate()
        {
          

            bool Loop = true;
            while (Loop)
            {
                Console.Clear();
                PrintMenu();
                UserSelect();
                

                switch (Selected)
                {
                    
                    case ConsoleKey.E:
                        Console.Clear();
                        Console.Write("Write a Number: ");
                        string text = Console.ReadLine();

                        float nr = text.MakeItFloat();
                        Console.WriteLine(nr);

                        Console.ReadKey();
                        break;

                    case ConsoleKey.L:
                        Linqer LQ = new Linqer();
                        LQ.Switch();
                        break;
                    case ConsoleKey.D:
                        LambdaLinq LL = new LambdaLinq();
                        LL.Switch();
                        break;
                    default:
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Navigate();




        }


    }
}
