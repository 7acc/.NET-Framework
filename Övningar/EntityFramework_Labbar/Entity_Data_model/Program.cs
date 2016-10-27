using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Data_model
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHandler DH = new DataHandler();
            DH.printEntity(new Author());
            Console.ReadKey();
            DH.printEntity(new Title());
            Console.ReadKey();

            Console.WriteLine("Add a Author");
            Console.Write("Firstname: ");
            var FirstName = Console.ReadLine();
            Console.Write("lastname: ");
            var LastName = Console.ReadLine();
            Console.WriteLine("PaymentMethod:  cash = 0, Bank = 1, Card = 2");
            ConsoleKeyInfo input = Console.ReadKey();
            int paymentMethod = int.Parse(input.KeyChar.ToString());


            var newAuthor = new Author
            {
                FirstName = FirstName,
                LastName = LastName,
                PaymentMethod = (MyEnums.MyPaymentMethod)paymentMethod
            };
            try
            {
                DH.AddEntity(newAuthor);
                Console.WriteLine("Author Added!");
                Console.WriteLine(newAuthor);
            }
            catch (Exception) { }
           

        }
    }
}
