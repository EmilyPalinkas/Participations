using System;

namespace _P__Simple_Method__Speak_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string dogNoise = "woof";
            string catNoise = "meow";
            string cowNoise = "moo";*/

            string answer;

            do
            {
                Console.WriteLine("Enter a type of animal");
                string animal = Console.ReadLine();

                Speak(animal);

                Console.WriteLine("Do you want to hear another animal? >>");
                answer = Console.ReadLine().ToLower();

            } while (answer[0] == 'y');


        }

        static string Speak(string animal)
        {
                string sound;
            

            if (animal == "dog")
            {
                sound = "woof";
                Console.WriteLine($"dog makes the sound {sound}");
            }
            else if (animal == "cat")
            {
                sound = "meow";
                Console.WriteLine($"cat makes the sound {sound}");

            }
            else if (animal == "cow")
             {
                sound = "moo";
                Console.WriteLine($"cow makes the sound {sound}");

            }
                
         }

    }
}
