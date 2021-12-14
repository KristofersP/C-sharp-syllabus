using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_
{
    class Odometer
    {
        private int _currentMileage;
        private int _mileageCounter = 0;

        public Odometer(int startMileage)
        {
            _currentMileage = startMileage;
        }

        public void ShowMileage()
        {
            Console.WriteLine($"The current mileage: {_currentMileage}");
        }

        public void IncrementMileage()
        {
            if(_currentMileage < 999999)
            {
                _currentMileage++;
                _mileageCounter++;
            }
            else
            {
                _currentMileage = 0;
                _mileageCounter++;
            }
        }
    }
}
