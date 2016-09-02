using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class list
    {
        public static void AddNumbersToList(List<int> listToAddTo, params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                listToAddTo.Add(list[i]);
            }
        }
        public static void Run()
        {
            List<int> intlist = new List<int>();
            intlist.Add(5);
            intlist.Add(12);
            intlist.Add(25);

            AddNumbersToList(intlist, 75, 45, 25, 12, 79, 80, 80);

            for (int i = 0; i < intlist.Count; i++)
            {
                Console.WriteLine(i + ": " + intlist[i]);
            }

            Console.WriteLine("the list contains the number 6: " + intlist.Contains(6));
            Console.WriteLine("the list contains the number 81: " + intlist.Contains(13));
            Console.ReadKey();

            intlist.Sort();
            Console.WriteLine("duplicates");
            foreach (var item in intlist)

            {
                Console.WriteLine(item.ToString());
            }


            Console.WriteLine("no duplicates");
            intlist = intlist.Distinct().ToList();

            foreach (var item in intlist)
            {
                Console.WriteLine(item.ToString());
            }

            intlist.RemoveAt(3);

            Console.WriteLine("element at index \"3\" removed");
            foreach (var item in intlist)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
    
}
