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
    partial class Ui
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

        public int SingleintInput(string request)
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
                Console.WriteLine("Incorrect User Input");
                Console.ReadKey();
                return -1;
            }
        }

        public int SingleintInput()
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
                Console.WriteLine("Incorrect User Input");
                Console.ReadKey();
                return -1;
            }
        }

        public int MultiIntInput(string request)
        {
            Console.Write(request);
            var input = Console.ReadLine();
            int outPut;
            bool isdigit = int.TryParse(input, out outPut);
            if (isdigit)
            {
                return outPut;
            }
            else
            {
                Console.WriteLine("Incorrect User Input");
                Console.ReadKey();
                return -1;
            }
        }
    

        public Authors NewAuthorInput()
        {
            var name = NameInput().Split(' ');
            var age = -1;
            while (age > 0)
            {
                age = SingleintInput("Age: ");
            }

            return new Authors
            {
                FirstName = name[0],
                LastName = name[1],
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

        public Authors ModifyAuthorInput(Authors authorToUpdate)
        {
            Authors BackupAuthor = authorToUpdate;
            bool loop = true;
            while (loop)
            {

                Console.Clear();
                Console.WriteLine(authorToUpdate);
                Console.WriteLine();

                switch (UserNavigation("to update?", "try again ;)"))
                {
                    case 1:
                        var Name = NameInput2();
                        authorToUpdate.FirstName = Name[0];
                        authorToUpdate.LastName = Name[1];
                        break;
                    case 2:
                        int age = SingleintInput("Enter age: ");
                        if (age > 0)
                        {
                            authorToUpdate.Age = age;
                        }
                        else
                        {
                            ErrorMessage("author need to be atleas 1 year old!");
                        }
                        break;
                    case 3:
                        return authorToUpdate;

                    case -2:

                        loop = false;
                        return authorToUpdate = BackupAuthor;

                }
            }
            return authorToUpdate;
        }
    }


}

