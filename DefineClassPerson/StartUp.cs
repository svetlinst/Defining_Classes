using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);
                Person currPerson = new Person(age, name);
                family.AddMember(currPerson);
            }
            Person oldest = new Person(family.GetOldestMember().Age, family.GetOldestMember().Name);
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
