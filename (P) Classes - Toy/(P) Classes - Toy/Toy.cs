using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";

        }

        public string GetNote()
        {
            return Notes;
        }

        public void SetNote(string information)
        {
            Notes = information;
        }

        public string GetAisle()
        {
            int num;
            Random ran = new Random();
            num = ran.Next(1, 25);
            return $"{Manufacturer.ToUpper()[0]} {num}";
        }
    }
}
