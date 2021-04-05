using System;
using System.Collections.Generic;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // question 1

            /*Create parallel arrays, one will have the course subject (e.g. MIS, MATH, etc.) 
           and the other will hold course numbers (e.g. 3033, 3013, etc.).  
           Ask the user to input 3 for each, store them in the array.  
           Then use a different loop to output the results to the user concatenated together (e.g. MIS3033, MATH3013).*/


            string[] name = new string[3];
            string[] course_num = new string[3];

            Console.WriteLine("Enter the name of a course and then the course number. Do this for three total courses.");

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("What is the name of your class?(e.g. MIS, MATH, ECON, etc.");
                name[i] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("what is the course number for the class? (e.g. 3013, 3030, etc) >>");
                course_num[i] = Console.ReadLine();

                Console.WriteLine();
            }

            List<string> course_names = new List<string>();

            for (int i = 0; i <= 2; i++)
            {
                course_names.Add($"{name[i]}{ course_num[i]}");
            }

            Console.WriteLine("The full course names are as follows:");

            foreach (var course in course_names)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine();

            //Questions 2

            /*Create a list that will hold all of the users grades.
             * Keep prompting the user if they have another grade to enter until they say 'no'.
             * Once you have all of the inputs, use a for each loop to iterate through the list 
             * and calculate the average.Output the users grade average. */


            List<double> c1grades = new List<double>();
            List<double> c2grades = new List<double>();
            List<double> c3grades = new List<double>();

            double sumC1 = 0, sumC2 = 0, sumC3 = 0, avgC1, avgC2, avgC3;
            string answer = "";

            //c1

            do
            {
                Console.WriteLine($"Please enter an exam grade for {course_names[0]}>>");
                double c1grade = Convert.ToDouble(Console.ReadLine());
                c1grades.Add(c1grade);
                sumC1 += c1grade;
                Console.WriteLine("Do you have more grades for this class? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
            Console.WriteLine();
            avgC1 = sumC1 / (c1grades.Count * 100);

            //c2

            do
            {
                Console.WriteLine($"Please enter an exam grade for {course_names[1]}>>");
                double c2grade = Convert.ToDouble(Console.ReadLine());
                c2grades.Add(c2grade);
                sumC2 += c2grade;
                Console.WriteLine("Do you have more grades for this class? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
            Console.WriteLine();
            avgC2 = sumC2 / (c2grades.Count * 100);


            //c3

            do
            {
                Console.WriteLine($"Please enter an exam grade for {course_names[2]}>>");
                double c3grade = Convert.ToDouble(Console.ReadLine());
                c3grades.Add(c3grade);
                sumC3 += c3grade;
                Console.WriteLine("Do you have more grades for this class? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
            Console.WriteLine();
            avgC3 = sumC3 / (c3grades.Count * 100);


            // question 3

            /*Create a dictionary that will hold multiple values. 
            The key will be the course code(e.g.MIS3013, MIS3383, etc.) 
            and the values will be all of the students final grades(e.g. 0.95, 0.8, etc.).
            Add at least 3 courses codes and at least 3 grades in each one. 
            Calculate the average for each course code and output it to the user, 
           make sure to format it as a percent. 
           1. If you have time, convert #3 to getting input from the user and 
            making sure the key doesn't exist prior to adding it*/


            Dictionary<string, List<double>> course_grades = new Dictionary<string, List<double>>();

            AddtoDictionary(course_grades, course_names[0], c1grades);
            AddtoDictionary(course_grades, course_names[1], c2grades);
            AddtoDictionary(course_grades, course_names[2], c3grades);

            Console.WriteLine($"your average grade for {course_names[0]} is {avgC1.ToString("P2")}");
            Console.WriteLine($"your average grade for {course_names[1]} is {avgC2.ToString("P2")}");
            Console.WriteLine($"your average grade for {course_names[2]} is {avgC3.ToString("P2")}");


        }

        static void AddtoDictionary(Dictionary<string, List<double>> myDictionary, string theKey, List<double> ListOfGrades)
        {

            if (!myDictionary.ContainsKey(theKey))
            {
                myDictionary.Add(theKey, ListOfGrades);
            }
            else
            {
                Console.WriteLine("Key already exists, bye dude");
                return;
            }


        }
    }
}
