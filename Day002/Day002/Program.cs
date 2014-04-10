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
            DateTime today = DateTime.Now;
            
            Console.WriteLine("Enter your birthday (mm/dd/yyyy format)");
            string input = Console.ReadLine();
            DateTime myBirthday = DateTime.Parse(input);

            Console.WriteLine("Your birthday is {0:d}", myBirthday);

            Console.WriteLine("Today is {0:d}", today);       

            Console.WriteLine("You are {0} days old!", calculateDaysOld(today, myBirthday));

            Console.WriteLine("You are {0} years old!", calculateAge(today, myBirthday));           

            Console.ReadLine();
        }

        static int calculateDaysOld(DateTime today, DateTime birthday)
        {
            TimeSpan daysOld = today - birthday;
            return daysOld.Days;
        }

        static int calculateAge(DateTime today, DateTime birthday)
        {
            int years = today.Year - birthday.Year;
            
            if (birthday > today.AddYears(-years))
            {
                years = years - 1;
            }

            return years;
        }
    }
}
