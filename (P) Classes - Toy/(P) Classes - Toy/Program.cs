using System;

namespace _P__Classes___Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            // first instance 
            Toy T = new Toy();
            T.Manufacturer = "Nerf inc.";
            T.Name = "Shot Gun";
            T.Price = 24.99;
            T.SetNote("Not a real shot gun");

            Console.WriteLine($"Aisle : {T.GetAisle()}");
            Console.WriteLine($"Toy Name : {T.Name}");
            Console.WriteLine($"Toy Price : {T.Price.ToString("C")}");
            Console.WriteLine($"Destcription : {T.GetNote()}");

            Console.WriteLine();

            //second instance
            T = new Toy();
            T.Manufacturer = "Fisher Price inc.";
            T.Name = "Dolly Girl";
            T.Price = 19.99;
            T.SetNote("The best dolly ever");

            Console.WriteLine($"Aisle : {T.GetAisle()}");
            Console.WriteLine($"Toy Name : {T.Name}");
            Console.WriteLine($"Toy Price : {T.Price.ToString("C")}");
            Console.WriteLine($"Destcription : {T.GetNote()}");
        }
    }
}
