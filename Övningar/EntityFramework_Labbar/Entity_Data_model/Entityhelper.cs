using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Data_model
{
    class Entityhelper
    {
    }
    public partial class Author
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name {FirstName} {LastName}\nPaymentmethod: {PaymentMethod}\nTitles ({Titles.Count})\n\n");
            if (Titles.Count > 0)
            {
                sb.Append("ISBN".PadRight(15) + "Title".PadRight(50) + "Copyroght\n\n");
                foreach (var item in Titles)
                {
                    sb.Append($"{item.ISBN.PadRight(15)} {item.Title1.PadRight(50)} ({item.Copyright})\n");
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
    public partial class Title
    {
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {Title1} -- Copyright: ({Copyright})\nEdition: {EditionNumber} ");

            sb.AppendLine("Authors\n");
            foreach (var item in Authors)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName}".PadRight(20)+ $"({item.AuthorID})");
            }
            return sb.ToString();
        }
    }
}
