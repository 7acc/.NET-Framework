using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pgrm = new Program();
            pgrm.Waiter();
            Console.ReadKey();
        }
        public async void Waiter()
        {
            Console.WriteLine("il wait here until your done");
            string hej = await Task.Run(() => Doer());
            
            Console.WriteLine(hej);
            Console.WriteLine("OK good!");
           
        }



        private string Doer()
        {
            Console.WriteLine("doing stuff");
            Thread.Sleep(3000);
            return "im done";
        }

        private void HAHA()
        {
            Console.WriteLine("im done faster");
        }
    }  
}
