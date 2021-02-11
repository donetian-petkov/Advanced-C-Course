using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int numberOfMembers = int.Parse(Console.ReadLine());

            while (numberOfMembers > 0)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);

                numberOfMembers--;

            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }

}