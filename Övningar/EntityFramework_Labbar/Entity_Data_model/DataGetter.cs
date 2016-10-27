using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Data_model
{
    class DataGetter
    {
        public BooksEntities BookContext;
        public List<object> GetAllEntitiesOfType<T>(T Entity) where T : class
        {                      
                List<Object> list = new List<Object>();

                foreach (var item in BookContext.Set(Entity.GetType()))
                {
                    list.Add(item);
                }

                return list;            
        }
        public List<Author> GetAllAuthors()
        {                       
                return BookContext.Authors.ToList();            
        }
    }
}
