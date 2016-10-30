using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    class Application
    {
        private DataAccess DataAccess { get; set; }
        private UI Ui { get; set; }

        public Application()
        {

            Ui = new UI();

            DataAccess = new DataAccess();
        }

        public void Start()
        {
            Navigate();
        }

        private void Navigate()
        {
            while (true)
            {
                Console.Clear();
                Ui.ShowMenu();
                switch (Ui.UserNavigation(""))
                {
                    case 1:
                        DataAccess.GetAllAuthors().PrintList();
                        Console.ReadKey();
                        break;
                    case 2:
                        FindAuther();
                        break;
                    case 3:
                        DataAccess.AddAuthor(Ui.NewAuthorInput());
                        break;
                    case 4:
                        UpdateAuthor();
                        break;
                    case -1:
                        break;

                    case -2:
                        return;
                    default:
                        break;
                }
            }
        }

        private Authors FindAuther()
        {
            var author = new Authors();
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Ui.ShowFindAuther();
                switch (Ui.UserNavigation())
                {
                    case 1:
                        DataAccess.GetAuthorById(Ui.UserNavigation("", ""));
                        break;
                    case 2:
                        var name = Ui.NameInput();
                        var authers = DataAccess.GetAuthorByName(name);

                        if (authers.Count == 1)
                        {
                            author = authers[0];
                            Console.ReadKey();
                        }
                        else if (authers.Count > 1)
                        {
                            authers.PrintList();
                            Console.WriteLine("enter the ID of the author you want to Update");
                        }
                        else
                        {
                            var nameArray = name.Split(' ');
                            authers = DataAccess.GetAuthorByName(nameArray[0], nameArray[1]);

                            if (authers.Count == 1)
                            {
                                author = authers[0];
                                loop = false;
                            }
                            else if (authers.Count > 1)
                            {
                                authers.PrintList();
                                var select = Ui.intInput("enter the ID of the author you want to Update");
                       
                                author = authers.GetAuthorByID(select);
                                break;
                            }
                            else
                            {
                                Ui.NotFound(name);
                            }
                        }

                        break;
                    case -2:
                        loop = false;
                        break;
                }

            }
            return author;
        }

        private void UpdateAuthor()
        {
            
            var selected = FindAuther();            
       
            if (selected != null)
            {           
                UpdateAuthorInput(selected);
            }
          
        }

        public void UpdateAuthorInput(Authors authorToUpdate)
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine(authorToUpdate);
                Console.WriteLine();

                switch (Ui.UserNavigation("to update?", "try again ;)"))
                {
                    case 1:
                        var Name = Ui.NameInput2();
                        authorToUpdate.FirstName = Name[0];
                        authorToUpdate.LastName = Name[1];
                        break;
                    case 2:
                        int age = Ui.intInput("Enter age: ");
                        if (age > 0)
                        {
                            authorToUpdate.Age = age;
                        }
                        else
                        {
                            Ui.ErrorMessage("author need to be atleas 1 year old!");
                        }
                        break;
                    case 3:
                        DataAccess.UpDateAuthor(authorToUpdate);
                        Console.WriteLine("Saved");
                        break;
                    case -2:
                        return;

                }
            }
        }
    }
}
