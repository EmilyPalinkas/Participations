using System;
using System.Collections.Generic;
using System.Text;

namespace _P__toyBox
{
    public class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }

        public string Location { get; set; }

        public override string ToString()
        {
            return ($"{Owner}'s ToyBox is located at {Location}");
        }
        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = "";
            Location = "";
        }

        public Toy GetRandomToy()
        {
            int Amnt = Toys.Count;
            Random R = new Random();
            int randomNum = R.Next(Toys.Count);
            return (Toys[randomNum]);

        }


    }
}