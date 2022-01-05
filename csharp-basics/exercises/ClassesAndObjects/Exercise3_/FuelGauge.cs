using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_
{
    class FuelGauge
    {
        private int _amountOfFuel;

        public FuelGauge(int startAmountOfFuel)
        {
            _amountOfFuel = startAmountOfFuel;
        }

        public void ShowFuel()
        {
            Console.WriteLine($"The amount of fuel left: {_amountOfFuel}");
        }
        
        public void IncrementFuel()
        {
            if(_amountOfFuel <= 70)
            {
                _amountOfFuel++;
            }
        }

        public void DecrementFuel()
        {
            if (_amountOfFuel > 0)
            {
                _amountOfFuel--;
            }
            else
            {
                Console.WriteLine("You are out of fuel! Go refill!");
            }
        }

        public int FuelLevel()
        {
            return _amountOfFuel;
        }

        public bool CarHasFuel()
        {
            return _amountOfFuel != 0;
        }
    }
}
