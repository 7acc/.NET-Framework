using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThred = new Thread(new ThreadStart(MyCallbackFunction));
            myThred.Start();
            Console.ReadKey();
        }

        private static void MyCallbackFunction()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("the thread is threding!!");
                i++;

                if (i == 10)
                {
                    break;
                }
            }
        }
    }
}
