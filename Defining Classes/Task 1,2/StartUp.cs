using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);

            Person gosho = new Person();
            gosho.Name = "Gosho";
            gosho.Age = 18;

            Person stamat = new Person("Stamat", 43);

        }
    }
}