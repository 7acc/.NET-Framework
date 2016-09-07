using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtentions
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} \n" +
                                 "age: {2}\n" +
                                 "Adress: {3}",
                                 FirstName, LastName, 
                                 Age,
                                 Adress);
        }
    }



}
