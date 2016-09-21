using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {

            string authorInfo = $"ID: {AuthorID}\nName: {FirstName} {LastName}";
            return authorInfo;
        }
    }
}
