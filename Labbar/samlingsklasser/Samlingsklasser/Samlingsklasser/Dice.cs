using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Dice
    {
        private static Random rnd;
        private static Dictionary<int, int> diceCount;
        public static void Run()
        {
            rnd = new Random();
            diceCount = new Dictionary<int, int>();
       
            for (int i = 0; i <= 1000; i++)
            {
                int dice = TrowDice();
                AddToCount(dice);
               
            }
            
            foreach (var item in diceCount)
            {
                Console.WriteLine("number {0} --- TotalCount {1}", item.Key, item.Value);
            }
            Console.ReadKey();            
        }

        private static int TrowDice()
        {                         
            return  rnd.Next(1, 7);
        }

        private static void AddToCount(int dice)
        {
            if (diceCount.ContainsKey(dice))
            {
                diceCount[dice] += dice;
            }
            else
            {
                diceCount.Add(dice, dice);
            }
           
        }
    }
}
