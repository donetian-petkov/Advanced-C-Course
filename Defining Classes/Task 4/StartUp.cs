using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Person> olderPeople = new List<Person>();

            while (numberOfPeople > 0)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (age > 30)
                {
                    Person newPerson = new Person(name, age);
                    olderPeople.Add(newPerson);
                }

                numberOfPeople--;
            }

            olderPeople = olderPeople.OrderBy(x => x.Name).ToList();

            foreach (var person in olderPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
   
}
