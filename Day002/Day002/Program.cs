using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday (mm/dd/yyyy format)");
            string input = Console.ReadLine();
            DateTime myBirthday = DateTime.Parse(input);

            Console.WriteLine("Your birthday is {0:d}", myBirthday);

            DateTime today = DateTime.Now;

            Console.WriteLine("Today is {0:d}", today);
            TimeSpan daysOld = today - myBirthday;

            Console.WriteLine("You are {0} days old!", daysOld.Days);

            int years = today.Year - myBirthday.Year;
            if (myBirthday > today.AddYears(-years))
            {
                years = years - 1;
            }

            Console.WriteLine("You are {0} years old!", years);           

            Console.ReadLine();
        }
    }
}
