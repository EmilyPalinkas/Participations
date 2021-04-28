using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Cereal__read_in_a_File_
{
    public class Cereal
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Calories { get; set; }

        public double Cups { get; set; }


        public Cereal()
        {
            Manufacturer = "";
            Name = "";
            Calories = 0;
            Cups = 0;
        }

        public override string ToString()
        {
            return $"{Name} : Manufacturer - {Manufacturer}, Calories - {Calories}, Serving Size - {Cups} cup(s)";
        }



    }
}
