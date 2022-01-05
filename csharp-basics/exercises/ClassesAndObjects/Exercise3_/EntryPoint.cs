using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_
{
    class EntryPoint
    {
        public static void Main()
        {
            int mileCounter = 0;

            FuelGauge carfuel = new FuelGauge(0);
            Odometer carodo = new Odometer(999950);

            Console.WriteLine("How many liters you want to put in the car? (Max 70)");
            int liters = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < liters; i++)
            {
                carfuel.IncrementFuel();
            }

            while (carfuel.CarHasFuel())
            {
                carodo.IncrementMileage();
                mileCounter++;

                if (mileCounter == 10) 
                {
                    carfuel.DecrementFuel();
                    mileCounter = 0;
                }
                
                carfuel.ShowFuel();
                carodo.ShowMileage();

                Thread.Sleep(200);
            }
        }
    }
}
