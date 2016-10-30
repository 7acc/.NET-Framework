using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_EF_CRUD
{
    public partial class Authors
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name {FirstName} {LastName}\nPaymentmethod:  ({Titles.Count})\n\n");
            if (Titles.Count > 0)
            {
                sb.Append("ISBN".PadRight(15) + "Title".PadRight(50) + "Copyroght\n\n");
                foreach (var item in Titles)
                {
                    sb.Append($"{item.ISBN.PadRight(15)} {item.Title.PadRight(50)} ({item.Copyright})\n");
                }
            }
            else
            {
                sb.Append("LAZY AUTHOR!!");
            }
            sb.Append("\n".PadRight(100, '.') + "\n");
            return sb.ToString();
        }
    }
}
