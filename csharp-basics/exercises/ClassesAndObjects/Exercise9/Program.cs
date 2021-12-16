using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        public static void Main()
        {
            SwapPoints p1 = new SwapPoints(1, 3);
            SwapPoints p2 = new SwapPoints(2, 4);

            p1.swapPoints(p1, p2);

            Console.WriteLine($"({p1.x}, {p1.y})");
            Console.WriteLine($"({p2.x}, {p2.y})");
        }
        
    }
}