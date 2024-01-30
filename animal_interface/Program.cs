using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACES - PART TWO\n\n");

            //Creating a list to hold animal objects:
            List<IAnimal> animals = new List<IAnimal>();


            //new dog object
            //name:
            Dog dog = new Dog();
            animals.Add(dog); //adds new dog object in animals list
            Console.WriteLine("\nEnter your dogs name: ");
            string dogName = Console.ReadLine();
            dog.Name = dogName;
            Console.WriteLine($"\nHello, {dogName}!");

            //colour of dog:
            Console.WriteLine("\nWhat is the colour of your dog? ");
            string dogColour = Console.ReadLine();
            dog.Colour = dogColour;

            //height of dog:
            Console.WriteLine("How tall, in cm, is your dog? ");
            double dogHeight = Convert.ToDouble(Console.ReadLine());
            dog.Height = dogHeight;

            //age of dog:
            Console.WriteLine("How old is your dog? ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            dog.Age = dogAge;

            //implenting Eat and Cry methods for Dog:
            dog.Eat();
            dog.Cry();


            //new cat object
            //name:
            Cat cat = new Cat();
            animals.Add(cat); //adds new cat object in animals list
            Console.WriteLine("\nEnter your cats name: ");
            string catName = Console.ReadLine();
            cat.Name = catName;
            Console.WriteLine($"\nHello, {catName}!");

            //colour of cat:
            Console.WriteLine("\nWhat is the colour for your cat: ");
            string catColour = Console.ReadLine();
            cat.Colour = catColour;

            //height of cat:
            Console.WriteLine("How tall, in cm, is your cat? ");
            double catHeight = Convert.ToDouble(Console.ReadLine());
            cat.Height = catHeight;

            //age of cat:
            Console.WriteLine("How old is your cat? ");
            int catAge = Convert.ToInt32(Console.ReadLine());
            cat.Age = catAge;

            //implenting Eat and Cry methods for Cat:
            cat.Eat();
            cat.Cry();


            //Printing the names of the animals added in the list "animals"
            Console.WriteLine("\n\nNames of all animals in the list: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            Console.ReadLine();

        }
    }
}
