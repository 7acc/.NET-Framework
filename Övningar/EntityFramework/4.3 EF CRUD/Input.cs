using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    partial class UI
    {

        public string NameInput()
        {
            Console.WriteLine("plz enter the Name");

            Console.Write("FirstName: ");
            var firstName = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Lastname: ");
            var lastName = Console.ReadLine().Trim().ToLower();

            return firstName + " " + lastName;

        }

        public string[] NameInput2()
        {
            Console.WriteLine("plz enter the Name");

            Console.Write("FirstName: ");
            var firstName = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Lastname: ");
            var lastName = Console.ReadLine().Trim().ToLower();
            var fullname = firstName + " " + lastName;
            return fullname.Split(' ');
        }

        public int intInput(string request)
        {
            Console.Write(request);
            var input = Console.ReadKey(true).KeyChar.ToString();
            int outPut;
            bool isdigit = int.TryParse(input, out outPut);
            if (isdigit)
            {
                return outPut;
            }
            else
            {
                Console.WriteLine("incorrect user input");
                Console.ReadKey();
                return -1;
            }
        }
        public int intInput()
        {
            var input = Console.ReadKey(true).KeyChar.ToString();
            int outPut;
            bool isdigit = int.TryParse(input, out outPut);
            if (isdigit)
            {
                return outPut;
            }
            else
            {
                Console.WriteLine("incorrect user input");
                Console.ReadKey();
                return -1;
            }
        }      
 
        public Authors NewAuthorInput()
        {
            var Name = NameInput().Split(' ');
            var age = -1;
            while (age > 0)
            {
                age = intInput("Age: ");
            }

            return new Authors
            {
                FirstName = Name[0],
                LastName = Name[1],
                Age = age
            };

        }

       public int UserNavigation()
        {
            var input = Console.ReadKey(true).KeyChar.ToString();
            int outPut;
            bool isdigit = int.TryParse(input, out outPut);
            if (isdigit)
            {
                return outPut;
            }
            else if (input.ToLower() == "q")
            {
                return -2;
            }
            else
            {
                ErrorMessage("incorrect user input");
                Console.ReadKey();
                return -1;
            }
        }

        public int UserNavigation(string Emessage)
        {
            var input = Console.ReadKey(true).KeyChar.ToString();
            int outPut;
            bool isdigit = int.TryParse(input, out outPut);
            if (isdigit)
            {
                return outPut;
            }
            else if (input.ToLower() == "q")
            {
                return -2;
            }
            else
            {
                ErrorMessage(Emessage);
                Console.ReadKey();
                return -1;
            }
        }

       public int UserNavigation(string request, string eMessage)
        {
            Console.WriteLine(request);
            var input = Console.ReadKey(true).KeyChar.ToString();
            int outPut;
            bool isdigit = int.TryParse(input, out outPut);
            if (isdigit)
            {
                return outPut;
            }
            else if (input.ToLower() == "q")
            {
                return -2;
            }
            else
            {
                ErrorMessage(eMessage);
                Console.ReadKey();
                return -1;
            }
        }




    }
}
