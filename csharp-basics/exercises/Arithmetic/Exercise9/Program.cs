using System;

namespace Exercise9
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Will you be using the metric(1) or imperial system(0)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your weight(lbs or kg):");
            float weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height(cm or in):");
            float height = Convert.ToInt32(Console.ReadLine());

            float bmi;

            if(choice == 0)
            {
                bmi = (weight * 703) / (height * height);
            }
            else
            {
                weight = weight * (float)2.20462262;
                height = height * (float)0.393700787;
                bmi = (weight * 703) / (height * height);
            }

            Console.WriteLine(bmi);
        }
    }
}