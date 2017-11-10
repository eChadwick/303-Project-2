using System;

namespace _303_Project_2
{
    class Program
    {
        static void Main(String[] args)
        {
            var test = new MorseHandler("morse.txt");
            Console.WriteLine(test.Encode("elephant"));
            Console.WriteLine(test.Decode(test.Encode("elephant")));
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
