using System;

namespace _P__Simple_Method__Speak_
{
    class Program
    {
        static void Main(string[] args)
        {

           

            string answer;

            do
            {
                Console.WriteLine("Enter a type of animal");
                string animal = Console.ReadLine().ToLower();

                string sound = Speak(animal);
                Console.WriteLine(sound);

                Console.WriteLine("Do you want to hear another animal? >>");
                answer = Console.ReadLine();

            } while (answer[0] == 'y');

            Console.WriteLine("bye");
        }

        static string Speak(string animal)
        {
                string sound;
            

            if (animal == "dog")
            {
                sound = "woof";
            }
            else if (animal == "cat")
            {
                sound = "meow";
            }
            else if (animal == "cow")
             {
                sound = "moo";
            }
            else
            {
                sound = "blah blah blah";
            }
            return sound;
                
         }

    }
}
