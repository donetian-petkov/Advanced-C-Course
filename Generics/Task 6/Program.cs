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

            List<Box<double>> listOfBoxes = new List<Box<double>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                
                listOfBoxes.Add(box);
            }

            double value = double.Parse(Console.ReadLine());

            Box<double> boxToCompare = new Box<double>(value);

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