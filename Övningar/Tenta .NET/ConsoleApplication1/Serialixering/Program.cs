using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialixering
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil minbil = new Bil
            {
                Name = "Bilhelvede",
                age = 7,
                owner = "Jacc",
                insured = false
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Bil));

            Stream stream = new FileStream("minlillabilfil2.txt",
                                               FileMode.Create
                                               );

            serializer.Serialize(stream, minbil);
            stream.Close();

            stream = new FileStream("minlillabilfil2.txt", FileMode.Open);
            Bil minBilIgen = (Bil)serializer.Deserialize(stream);
         
            Console.WriteLine($"{minBilIgen.Name} {minBilIgen.age} {minBilIgen.owner} {minBilIgen.insured}");
            Console.ReadKey();

        }
    }
  
    public class Bil
    {
     
        public string Name { get; set; }
        public int age { get; set; }
        public string owner { get; set; }
        public bool insured { get; set; }


    }
}
