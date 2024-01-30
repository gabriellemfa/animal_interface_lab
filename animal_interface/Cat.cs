using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }


        public void Eat()
        {
            Console.WriteLine("Cats drink milk");
        }

        public string Cry()
        {
            return "meow!";
        }

    }
}
