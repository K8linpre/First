using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Question2();
            Question3.question3();
            Question3.Question4();
            Question5.question5();  
        }

        static void Question2()
        {
            int num1 = 74;
            int num2 = 36;
            int total = num1 + num2;
            Console.WriteLine(total);
        }
    }
    public class Question3
    {
        public static void question3()
        {                       
            Console.WriteLine("Please enter number one...");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number two...");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1*num2));

        }
        public static void Question4()
        {
            Console.WriteLine("Please enter your first name:");
            string first = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string last = Console.ReadLine();

            Console.WriteLine("Your full name is {0} {1}", first, last);
        }
    }
    public class Question5
    {
        public static void question5()
        {
            int i;

            Console.WriteLine("Pick a number between 1 and 12:");
            int num1 = int.Parse(Console.ReadLine());

            for (i = 0; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num1, i, (num1 * i));
            }

        }
    }
}
