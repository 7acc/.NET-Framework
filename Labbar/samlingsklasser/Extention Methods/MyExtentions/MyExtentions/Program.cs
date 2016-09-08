using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtentions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personListan = new List<Person>();

            Person p1 = new Person() { FirstName = "Allan" }; 
            Person p2 = new Person() { FirstName = "Ballan" };
            Person p3 = new Person() { FirstName = "Kalle" };
            Person p4 = new Person() { FirstName = "Piere" };
            Person p5 = new Person() { FirstName = "Sturtgarden" };


            personListan.objToList(p1, p2, p3, p4, p5);
            personListan.PrintPersons();
            Console.Read();


           Person found = personListan.FindPersonInList("Kalle");
            Console.WriteLine(found);
            Console.ReadKey();


            

        }
    }
}
