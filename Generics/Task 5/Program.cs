using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            List<Box<string>> listOfBoxes = new List<Box<string>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                
                listOfBoxes.Add(box);
            }

            string value = Console.ReadLine();

            Box<string> boxToCompare = new Box<string>(value);

            int count = GetGreaterThanCount(listOfBoxes, boxToCompare);
            
            Console.Write(count);
        }

        public static int GetGreaterThanCount<T>(List<Box<T>> boxes, Box<T> element)
        where T : IComparable
        {
            int count = 0;

            foreach (var box in boxes)
            {
                int compare = box.Value.CompareTo(element.Value);
                
                if (compare > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}