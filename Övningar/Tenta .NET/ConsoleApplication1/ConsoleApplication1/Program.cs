using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Scooter
    {
        public int Miltal { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string RegNr { get; set; }

        public static explicit operator Car(Scooter scoot)
        {
            return new Car
            {
                Age = scoot.Age,
                Miltal = scoot.Miltal,
                Color = scoot.Color,
                RegNr = scoot.RegNr
            };
        }

       public static implicit operator string(Scooter scoot)
        {
            return scoot.RegNr;
            
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car {Miltal = 10, Age = 23};
            Car car2 = new Car {Miltal = 20, Age = 10};
    

            var car3 = car1 + car2;

            Console.WriteLine(car3);
            Console.ReadKey();
            Scooter scoot = new Scooter
            {
                Miltal = 99,
                Age = 10,
                Color = "red",
                RegNr = "123 abc"
            };

            Car car4 = (Car)scoot;
            Console.WriteLine(car4 + "\n......................................");
            Console.ReadKey();
            string scootreg = scoot;
            Console.WriteLine(scootreg);
            Console.ReadKey();

        }
    }

    class Car
    {
        public int Miltal { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string RegNr { get; set; }

        public static Car operator +(Car c1, Car c2)
        {
            return new Car
            {
                Miltal = c1.Miltal + c2.Miltal,
                Age = c1.Age + c2.Age
            };
        }

        public override string ToString()
        {
            return $"Miltal: {Miltal} ålder: {Age} Color: {Color} RegNR: {RegNr} ";
        }
    }


}
