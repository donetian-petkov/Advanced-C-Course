using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < (inputNumber[0]+inputNumber[1]); i++)
            {
                if (i < inputNumber[0])
                {
                    firstSet.Add(int.Parse(Console.ReadLine()));
                }
                else
                {
                    secondSet.Add(int.Parse(Console.ReadLine()));
                }
            }
            
            for (int i = 0; i < )

            Console.WriteLine(string.Join(Environment.NewLine, usernames));

        }
    }
}