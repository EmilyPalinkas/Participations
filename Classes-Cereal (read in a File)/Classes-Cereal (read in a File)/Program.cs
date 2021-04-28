using System;
using System.Collections.Generic;
using System.IO;

namespace Classes_Cereal__read_in_a_File_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            List<Cereal> bowls = new List<Cereal>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] breaks = lines[i].Split("|");

                Cereal C = new Cereal();

                C.Name = breaks[0];
                C.Manufacturer = breaks[1];
                C.Calories = Convert.ToDouble(breaks[2]);
                C.Cups = Convert.ToDouble(breaks[3]);

                bowls.Add(C);
            }

            Console.WriteLine("The following cereals have a serving size of 1 cup or more:");

            foreach (Cereal cereal in bowls)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal.ToString());
                }
            }

            Console.WriteLine();
            Console.WriteLine("The following cereals have 100 calories or less per serving");

            foreach (Cereal cereal in bowls)
            {
                if (cereal.Calories <= 100)
                {
                    Console.WriteLine(cereal.ToString());
                }
            }
        }
    }
}
