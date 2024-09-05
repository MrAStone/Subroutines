using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subroutines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // This is a procedure
            Console.WriteLine(Math.Pow(7, 2)); // this is a function as it returns a value
            sayHello(); // this is a subroutine call
            sayHello(); // this is another subroutine call
            int b = giveMeANumber(); // this is a function call
            Console.WriteLine(b);
        }
        static void sayHello() // procedure (Returns nothing - void)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Look at me!");
            Console.WriteLine("I am a subroutine");
        }

        static int giveMeANumber() // function (Returns a value - int)
        {
            return 42;
        }
        static string makeFullName()
        {
            string firstname;
            string lastname;
            Console.Write("Enter first name: ");
            firstname = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastname = Console.ReadLine();
            return firstname + " " + lastname;
        }
        //Write a subroutine that will ask the user how many numbers they want to multiply.
        //   Ask the user to enter a number for each time they want to multiply
        //Return all the numbers multiplied together
        static int multiplyNumbers()
        {
            int numInput;
            Console.Write("How many numbers do you want to multiply? ");
            numInput = Convert.ToInt32(Console.ReadLine());
            int total = 1;
            for( int i = 1; i <= numInput; i++)
            {
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                total *= num; // total = total * num;
            }
            return total;
        }   
    }
}
