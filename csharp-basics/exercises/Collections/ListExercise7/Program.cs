﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise7
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
                "Black"
            };

            for(int i = 0; i < colors.Count(); i++)
            {
                if(colors[i] == "White")
                {
                    Console.WriteLine("The list contains White");
                }
            }

            Console.ReadKey();
        }
    }
}
