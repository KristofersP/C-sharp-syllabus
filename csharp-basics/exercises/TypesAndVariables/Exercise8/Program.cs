using System;

namespace Exercise8
{
    class Program
    {
        private static void Main(string[] args)
        {
            int minutes = 5000000;
            int years = minutes / 524600;
            int days = minutes % 524600 / 1440;

            Console.WriteLine(years + " years and " + days + " days");
        }
    }
}
