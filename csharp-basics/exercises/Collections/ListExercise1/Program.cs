﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();
            
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Black");
            colors.Add("White");

            colors.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
