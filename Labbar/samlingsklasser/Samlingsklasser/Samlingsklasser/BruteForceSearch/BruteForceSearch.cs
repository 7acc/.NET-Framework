using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class BruteForceSearch
    {

        public static void Run()
        {
            List<int> theList = ListMaker.GetFilledList(1000);

            //string numbers = Console.ReadLine();
            //int number = int.Parse(numbers);

            //Console.WriteLine(BruteForce(number, theList));
            //Console.ReadKey();

            bubbleSort(theList);
            for (int i = 0; i < theList.Count; i++)
            {
                Console.WriteLine("[{0}] --- {1}", i, theList[i]);
            }
            Console.ReadKey();

            theList.Sort();
            Console.WriteLine("number to search for: ");
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < theList.Count; i++)
            {
                Console.WriteLine("[{0}] --- {1}", i, theList[i]);
            }
            int index = BinarySearch(theList, key);
            if (index == -1)
            {
                Console.WriteLine("the number {0}, could not be found", key);
            }
            else
            {
                Console.WriteLine("the number {0} was found on index {1}", key, index);
            }
            Console.WriteLine("\n");
        
            Console.ReadKey();
               


            //int passCode = int.Parse(ReadPassword());
            //passCode = BruteSearch_passCode(passCode);
            //Console.WriteLine(passCode);
        }
        private static string BruteForce(int number, List<int> collection)
        {

            foreach (int nr in collection)
            {
                if (nr == number)
                {
                    return "The number you were looking for was found";
                }
            }
            return "Number not found";
        }
        private static int BruteSearch_passCode(int passCode)
        {
            StringBuilder result = new StringBuilder();
            string code = passCode.ToString();

            foreach (char number in code)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i.ToString() == number.ToString())
                    {
                        result.Append(i);
                    }
                }
            }

            string nu = result.ToString();
            return int.Parse(nu);
        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                       
                        password = password.Substring(0, password.Length - 1);
                    
                        int pos = Console.CursorLeft;
                       
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                     
                        Console.Write(" ");
                    
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
        public static int BinarySearch(IList<int> list, int Key)
        {
            int min = 0;
            int max = list.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (Key == list[mid])
                {
                    return mid;
                }
                else if (Key < list[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        public static void Swap(List<int> list, int big, int small )
        {
            int temp = list[big];
            list[big] = list[small];
            list[small] = temp;
        }
        public static void bubbleSort(List<int> list)
        {
            bool unSorted = true;
            int end = list.Count - 1;

            while(unSorted)
            {
                unSorted = false;
                for (int j = 0; j < end; j++)
                {
                    if(list[j] > list[j+1])
                    {
                        Swap(list, j, j + 1);
                        unSorted = true;
                    }
                    
                }
               
            }
        }
    }
}
