using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SampleCSharp
{
    public class ReverseString
    {
        public void Execute()
        {
            // the string to be reversed
            string sampleString = "one two three four five six";

            //expected string output - "eno owt eerht ruof evif xis"

            //normal way
            string[] strArray = sampleString.Split(" ");

            string resultString = "";

            foreach(string x in strArray)
            {
                resultString = resultString + " " + new String(x.Reverse().ToArray());
            }



            // in one line
            //string resultString = string.Join(" ", sampleString.Split(' ').Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(resultString);



        }
    }
}
