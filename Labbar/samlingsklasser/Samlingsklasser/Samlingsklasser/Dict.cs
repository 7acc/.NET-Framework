using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Dicti
    {
        public static Dictionary<string, int> dict = new Dictionary<string, int>();
        public static void Run()
        {

            dict.Add("Thomas", 5);
            dict.Add("Elizabeth", 4);
            dict.Add("Jacc", 10);

            foreach (var item in dict)
            {
                Console.WriteLine("name: {0} - Grade {1}", item.Key, item.Value);
            }
            Console.ReadKey();

            dict = new Dictionary<string, int>
            {
                { "Thomas", 5 },
                { "Elizabeth", 4 },
                { "Jacc", 10},
                { "Santa" ,3 },
                { "GingerBread-Man",1 },
                { "Dr.Who",9 },
                { "Mc.Fly" ,5},
                { "Toby",7 },
                { "cinderella",2 },
                { "santa" ,3}


            };
            Console.ReadKey();
            foreach (var item in dict)
            {
                Console.WriteLine("name: {0} - Grade {1}", item.Key, item.Value);
            }

            Console.WriteLine("the dictionary contains a pair with the value 5: " + dict.ContainsValue(5).ToString());
            Console.WriteLine("the dictionary contains a pair with the value 11: " +dict.ContainsValue(11).ToString());
            Console.ReadKey();

            RemoveDuplicatesFromDict(dict);
            Console.ReadKey();
            
            foreach (var item in dict)
            {
                Console.WriteLine("name: {0} - Grade {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }

        public static void RemoveDuplicatesFromDict(Dictionary<String, int> theDict)
        {
            for (int i = 0; i < theDict.Count; i++)
            {
                string key = theDict.ElementAt(i).Key;
                int value = theDict.ElementAt(i).Value;
                for (int j = i+1; j < theDict.Count; j++)
                {
                    if (value == theDict.ElementAt(j).Value)
                    {
                        theDict.Remove(key);
                        
                    }
                 
                }
            }
        }
    }
}