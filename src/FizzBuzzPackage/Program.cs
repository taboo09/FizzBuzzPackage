using System;

namespace FizzBuzzPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzResult = FizzBuzz.GetResult(555);

            Console.WriteLine(fizzBuzzResult);
        }
    }
}
