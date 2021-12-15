using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
     class Date
    {
        private int _month;
        private int _year;
        private int _day;
        public int Month 
        {
            get
            {
                return _month;
            }
            set
            {
                if (value > 0 && value < 13)
                {
                    _month = value;
                }
                else
                {
                    _month = 1;
                }
            } 
        }
        public int Year 
        { 
            get
            {
                return _year;
            }
            set
            {
                if (value > -1)
                {
                    _year = value;
                }
                else
                {
                    _year = 1;
                }
            } 
        }
        public int Day 
        {
            get
            {
                return _day;
            }
            set
            {
                if (value > 0 && value < 32)
                {
                    _day = value;
                }
                else
                {
                    _day = 1;
                }
            }
        }

        public Date(int year, int month, int day)
        {
            Month = month;
            Year = year;
            Day = day;
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{_month}/{_day}/{_year}");
        }
    }
}
