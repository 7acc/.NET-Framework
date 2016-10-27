using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Data_model
{
    class DataHandler
    {
        public static DataGetter Getter { get;  private set; }
        public DataHandler()
        {
            Getter = new DataGetter();
        }

        public void printEntity(Object entity)
        {
            using (Getter.BookContext = new BooksEntities())
            {
                var entities = Getter.GetAllEntitiesOfType(entity);
                entities.ForEach(x => Console.WriteLine(x));
            }
        }

        public void RemoveEntityByID(int ID)
        {
            using (Getter.BookContext = new BooksEntities())
            {

            }
        }
        public void AddEntity<T>(T Entity)
        {
            using (BooksEntities BookContext = new BooksEntities())
            {
                BookContext.Set(Entity.GetType()).Add(Entity);
                BookContext.SaveChanges();
            };
        }

    }
}
