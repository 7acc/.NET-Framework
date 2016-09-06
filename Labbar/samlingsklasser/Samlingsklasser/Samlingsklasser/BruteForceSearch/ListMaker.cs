using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class ListMaker
    {
       

        public static List<int> GetFilledList(int Range)
        {
            Random rnd = new Random();
            List<int> FilledList = new List<int>();

            for (int i = 0; i <= 200; i++)
            {
                int tal = rnd.Next(1, Range);
               while(FilledList.Contains(tal))
                {
                    tal = rnd.Next(1, Range);
                }

                FilledList.Add(tal);
            }
            return FilledList;

        }

    }
}
