using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
    class Program
    {
        delegate void testDelegate(string s);
        static List<int> list;
        static void Main(string[] args)
        {
            list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            DelegateThingy();
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();
            LambdaExpressionSyntax();
        }
        static void PrintEvenNumbers(List<int> evenNumbers)
        {
            Console.WriteLine("Even Numbers!");
            evenNumbers.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
        static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }
        static void TraditionalDelegateSyntax()
        {
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            PrintEvenNumbers(evenNumbers);
        }

        static void AnonymousMethodSyntax()
        {
            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2) == 0; });

            PrintEvenNumbers(evenNumbers);
        }

        static void LambdaExpressionSyntax()
        {
            List<int> evenNnumbers = list.FindAll((int i) => (i % 2) == 0);
            PrintEvenNumbers(evenNnumbers);
        }

        static void DelegateThingy()
        {
            testDelegate mydelegate = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            mydelegate("hello");
        }

    }
}
