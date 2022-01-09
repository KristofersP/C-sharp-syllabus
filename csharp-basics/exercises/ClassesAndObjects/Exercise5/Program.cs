using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class DateTest
    {
        public static void Main()
        {
            var date = new Date(-5, -1, -3);

            Console.WriteLine(date.DisplayDate());
        }
    }
}

