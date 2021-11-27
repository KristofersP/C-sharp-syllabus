using System;

namespace ClassesAndTeachers
{
    class Program
    {
        private static void Main(string[] args)
        {
            string english = "English";
            string math = "Math";
            string music = "Music";
            string history = "History";
            string biology = "Biology";

            string englishTeacher =        "I.Abele";
            string mathTeacher    =     "I.Salijuma";
            string musicTeacher   =     "L.Jaunzema";
            string historyTeacher =      "V.Klisans";
            string biologyTeacher = "O.Whatshername";

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine($"| 1 |                   {english} |                    {englishTeacher} |");
            Console.WriteLine($"| 2 |                      {math} |                 {mathTeacher} |");
            Console.WriteLine($"| 3 |                     {music} |                 {musicTeacher} |");
            Console.WriteLine($"| 4 |                   {history} |                  {historyTeacher} |");
            Console.WriteLine($"| 5 |                   {biology} |             {biologyTeacher} |");
            Console.WriteLine("+------------------------------------------------------------+");


        }
    }
}