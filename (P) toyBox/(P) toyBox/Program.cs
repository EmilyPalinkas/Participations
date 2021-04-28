using System;
using System.Collections.Generic;
using System.Linq;

namespace _P__toyBox
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ToyBox> boxes = new List<ToyBox>();

            string answer;

            do
            {


                ToyBox toybox = new ToyBox();

                Console.WriteLine("who owns this toy box? >>");
                toybox.Owner = Console.ReadLine();
                Console.WriteLine($"Where is this toy box located? >>");
                toybox.Location = Console.ReadLine();

                do
                {
                    Toy toy = new Toy();

                    Console.WriteLine("What is the name of the toy in this box >>");
                    toy.Name = Console.ReadLine();
                    Console.WriteLine("Who is the manufacturer? >>");
                    toy.Manufacturer = Console.ReadLine();
                    Console.WriteLine("What is the price of the toy? >>");
                    toy.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Toy note/description >>");
                    toy.SetNote(Console.ReadLine());
                    toybox.Toys.Add(toy);

                    Console.WriteLine("is there another toy in this box? >>");
                    answer = Console.ReadLine().ToLower();


                } while (answer[0] == 'y');

                boxes.Add(toybox);

                Console.WriteLine("Do you have another toy box? >>");
                answer = Console.ReadLine().ToLower();


            } while (answer[0] == 'y');

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
                Console.WriteLine("It holds the following items:");

                foreach (var toy in box.Toys)
                {
                    Console.WriteLine(toy);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("The following are a random toy from each toy box:");

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
                Toy r = box.GetRandomToy();
                Console.WriteLine(r);
                Console.WriteLine();
            }
            
        }
    }
}
