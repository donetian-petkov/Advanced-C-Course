using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());

                Console.WriteLine(box.ToString());
            }
        }
    }
}