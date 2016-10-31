using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_something_something
{
    static class Tryer
    {
        public static void TryingStuff()
        {
           
            var list = Process.GetProcesses().OrderBy(x => x.ProcessName);
            Console.WriteLine(list.Count());
            foreach (var process in list)
            {
                Console.WriteLine("Process: {0} ID: {1} some other stuff: {3}", process.ProcessName.PadRight(55, '-'), process.Id);
            }
            //var skype = list.FirstOrDefault(x => x.ProcessName == "Skype");
            //skype.Kill();
         
            Console.ReadKey();
           

        }
    }
}
