using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    internal class Application
    {
        private DataAccess DataAccess { get; set; }

        private Ui Ui { get; set; }

        public Application()
        {
            Ui = new Ui();

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
                Ui.ShowMenu();
                switch (Ui.UserNavigation(""))
                {
                    case 1:
                        Ui.PrintList(DataAccess.GetAllAuthors());                            
                        break;
                    case 2:
                        var foundAuthor = FindAuther();
                        Ui.Print(foundAuthor.ToString());                    
                        break;
                    case 3:
                        DataAccess.AddAuthor(Ui.NewAuthorInput());
                        break;
                    case 4:
                        var foundAuthorToUpdate = FindAuther();
                        UpdateAuthor(foundAuthorToUpdate);
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
                        }
                        else if (authers.Count > 1)
                        {
                            authers.PrintList();
                            var select = Ui.MultiIntInput("Select Author By ID");
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
                                var select = Ui.MultiIntInput("Select Author By ID");

                                author = authers.GetAuthorByID(select);
                            }
                            else
                            {
                                Ui.NotFound(name);
                                break;
                            }
                        }
                        loop = false;
                        return author;
                    case -2:
                        loop = false;
                        break;
                }
            }           
            return author;
        }

        private void UpdateAuthor(Authors authorToUpdate)
        {
            if (authorToUpdate != null)
            {
                var modifedauthor = Ui.ModifyAuthorInput(authorToUpdate);
                DataAccess.UpDateAuthor(modifedauthor);
            }
        }

        private void AddAuthor(Authors authorToAdd)
        {
            
            if(authorToAdd != null)
            DataAccess.AddAuthor(authorToAdd);

            else
            {
              Ui.ErrorMessage("Unable To Add Author");  
            }
        }

    }
}
