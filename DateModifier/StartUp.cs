using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            DateModifier days = new DateModifier(firstDate, secondDate);
            Console.WriteLine($"{days.CalculateDaysDiff()}");

        }
    }
}
