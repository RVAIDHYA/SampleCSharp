using System;

namespace SampleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Reverse string
            ReverseString reverseString = new ReverseString();
            reverseString.Execute();

            Console.ReadKey();
        }
    }
}
