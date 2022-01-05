using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black",
                "Red1",
                "Green1",
                "Orange1",
                "White1",
                "Black1"
            };

            colors.Insert(4, "Yellow");

            colors.Insert(colors.Count() - 1, "Yellow");

            colors.Sort();
            
            for (int i = 0; i < colors.Count(); i++)
            {
                if (colors[i] == "Foobar")
                {
                    Console.WriteLine("Yes");
                }
            }

            foreach (var item in colors)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
