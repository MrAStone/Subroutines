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
            Console.WriteLine( Math.Pow(7,2)); // this is a function as it returns a value
            sayHello(); // this is a subroutine
            sayHello();
        }
        static void sayHello()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Look at me!");
            Console.WriteLine("I am a subroutine");

        }
       
    }
}
