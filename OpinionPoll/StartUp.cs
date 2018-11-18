using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var entries = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < entries; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                Person currPerson = new Person(int.Parse(input[1]), input[0]);
                people.Add(currPerson);
            }

            foreach (var person in people.Where(p=>p.Age>30).OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
