using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class LambdaLinq
    {
        public string Alternatives = "";
        public void Switch()
        {
            Console.Clear();
            Console.WriteLine(Alternatives);
            var input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.S:
                  
                    break;

                case ConsoleKey.P:
                   
                    break;
            }
        }


       
    }
}
