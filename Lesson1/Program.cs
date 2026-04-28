using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                   /*Learn variables and data types*/
namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to C# world");
            /*when I want to ask the user to type something*/
            Console.ReadLine("Enter your name: ");

            Console.WriteLine("data types");
            /*Integir*/
            int a = 35;
            Console.WriteLine(a);
            double b = 23.5;
            Console.WriteLine(b);
            /*We use F to show that is float number otherwise the compiler will think that is double number*/
            float c = 23.5F;
            Console.WriteLine(b);

        }
    }
}
