using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a date (Format: august 29, 2018 or 8/29/2018)");
            string dateInput1 = Console.ReadLine();
            DateTime date1;

            while (!DateTime.TryParse(dateInput1, out date1))
            {

                Console.WriteLine("Invalid! Please enter a date (Format: august 29, 2018 or 8/29/2018)");
                dateInput1 = Console.ReadLine();
                DateTime.TryParse(dateInput1, out date1);
            }

            Console.WriteLine("Please enter a date (Format: august 29, 2018 or 8/29/2018)");
            string dateInput2 = Console.ReadLine();
            DateTime date2;

            while(!DateTime.TryParse(dateInput2, out date2))
            {
                
                Console.WriteLine("Invalid! Please enter a date (Format: august 29, 2018 or 8/29/2018)");
                dateInput2 = Console.ReadLine();
                DateTime.TryParse(dateInput2, out date2);
            }

            TimeSpan span = date2.Subtract(date1);
            Console.WriteLine(span);
        }
    }
}
