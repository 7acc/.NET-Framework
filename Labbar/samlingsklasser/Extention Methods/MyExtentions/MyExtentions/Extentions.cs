using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtentions
{
    static class Extentions
    {

        public static Person FindPersonInList(this List<Person> list, string name)
        {
            Person found = list.Find(x => x.FirstName == name);
            return found;
        }

        public static void NumbersToList(this List<int> list, params int[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                list.Add(i);
            }

        }
        public static void objToList(this List<Person> list, params Person[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                list.Add(param[i]);
            }
        }

        public static void PrintPersons(this List<Person> list)
        {
            foreach (Person P in list)
            {
                Console.WriteLine(P.ToString());
            }
        }
    }
}
