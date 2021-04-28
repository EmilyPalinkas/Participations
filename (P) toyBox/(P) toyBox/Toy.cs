using System;
using System.Collections.Generic;
using System.Text;

namespace _P__toyBox
{
    public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public override string ToString()
        {
            return ($"Toy Name: {Name}\nManufacturer Name: {Manufacturer} \nPrice: {Price.ToString("C")}\nNote: {GetNote()}\nAisle: {GetAisle()}");
        }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public Toy(string notes)
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = notes;
        }

        public string GetNote()
        {
            return Notes;
        }

        public void SetNote(string information)
        {
            Notes += "" + information;
        }

        public string GetAisle()
        {
            Random R = new Random();
            int randomNum = R.Next(1, 25);
            return $"{Manufacturer.ToUpper()[0]} {randomNum}";
        }
    }
}
