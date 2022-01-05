using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Student : Person
    {
        private double _gpa;

        public void DisplayGPA()
        {
            Console.WriteLine("GPA: " + _gpa);
        }

        public double Gpa
        { 
            get { return _gpa; }
            set 
            { 
                if(value <= 100 && value >= 0)
                {
                    _gpa = value;
                }
                else
                {
                    _gpa = -1;
                }
            }
        }
    }
}
