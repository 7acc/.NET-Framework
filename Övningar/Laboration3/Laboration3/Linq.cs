using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    class Linqer
    {

        public string Alternatives = "(S)how All Names\n" +
                              "(P)rint All that Begins with: ";
        public List<String> Names { get; set; }
        public Linqer()
        {
            Names = new List<string>();
            Names.Add("Jacc");
            Names.Add("Sture");
            Names.Add("Abraham");
            Names.Add("Attaturk");
            Names.Add("Fäsk");
            Names.Add("Gunnar");
            Names.Add("Svinepäls");
            Names.Add("jan Stenmark");
            Names.Add("Görtel");


        }
        public void ShowAll()
        {
            Names.ForEach(x => Console.WriteLine(x));
        }
        public void ShowAllThatBeginsWith(string beginsWith)
        {
            var list = from X in Names
                       where X.StartsWith(beginsWith)
                       select X;

            foreach (var Name in list)
            {
                Console.WriteLine(Name);
            }



        }
        public void Switch()
        {
            Console.Clear();
            Console.WriteLine(Alternatives);
            var input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.S:
                    ShowAll();
                    Console.ReadKey();
                    break;

                case ConsoleKey.P:
                    Console.Write("Show All That begins With:");
                    string search = Console.ReadLine();
                    ShowAllThatBeginsWith(search);
                    Console.ReadKey();
                    break;
            }
        }

    }
}
