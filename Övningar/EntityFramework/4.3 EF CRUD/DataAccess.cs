using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    class DataAccess
    {

        public List<Authors> GetAllAuthors()
        {
            var list = new List<Authors>();
            using (BooksEntities BE = new BooksEntities())
            {
                list = BE.Authors.Include("Titles").ToList();
            }           
            return list;
        }

        public Authors GetAuthorById(int ID)
        {
            using (BooksEntities BE = new BooksEntities())
            {
                return BE.Authors.Include("Titles").FirstOrDefault(x => x.AuthorID == ID);
            }
        }

        public List<Authors> GetAuthorByName(string firstName, string lastName)
        {
            List<Authors> list = new List<Authors>();

            using (BooksEntities BE = new BooksEntities())
            {
                list.AddRange(BE.Authors.Where(x => x.FirstName.ToLower() == firstName.ToLower()).Include("Titles"));
                list.AddRange(BE.Authors.Where(x => x.LastName.ToLower() == lastName.ToLower()).Include("Titles"));
            }
          
            return list;
        }

        public List<Authors> GetAuthorByName(string FullName)
        {
            List<Authors> list = new List<Authors>();

            using (BooksEntities BE = new BooksEntities())
            {
                list.AddRange(BE.Authors.Where(x => (x.FirstName + " " + x.LastName).ToLower() == FullName).Include("Titles"));
            }
            return list;
        }

        public void AddAuthor(Authors author)
        {
            using (BooksEntities BE = new BooksEntities())
            {
                BE.Authors.Add(author);
                BE.SaveChanges();
            }
        }
        public void RemoveAuthorById(int id)
        {
            using (BooksEntities BE = new BooksEntities())
            {
                BE.Authors.Remove(BE.Authors.Find(id));
                BE.SaveChanges();
            }
        }
   
        internal void UpDateAuthor(Authors authorToUpdate)
        {
            using (BooksEntities BE = new BooksEntities())
            {
                var authorToBeUpdated = BE.Authors.Find(authorToUpdate.AuthorID);
                authorToBeUpdated.FirstName = authorToUpdate.FirstName;
                authorToBeUpdated.LastName = authorToUpdate.LastName;
                authorToBeUpdated.Age = authorToUpdate.Age;
                
                BE.SaveChanges();
            }
        }
    }
}
