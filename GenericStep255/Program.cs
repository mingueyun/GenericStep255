using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStep255
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guess = new List<string>();
            guess.Add("james");
            guess.Add("jack");
            guess.Add("jones");
            foreach (var gues in guess)
            {
                Console.WriteLine("this is in string gues; " + gues);
            }

            List<int> guess2 = new List<int>() { 1, 2, 3, 4};
            foreach (var gues2 in guess2)
            {
                Console.WriteLine(gues2);
            }



            Employee<String >individual = new Employee<String>();
            individual.firstName = "Sample";
            individual.lastName = "Student";
            individual.SayName();



            Console.ReadLine();
        }
    }
}
