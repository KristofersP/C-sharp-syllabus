﻿namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double startKilometers;
        private double endKilometers;
        private double liters;
        public Car(double startOdo)
        {  
            startKilometers = startOdo; 
        }

        public double CalculateConsumption()
        {
            return (endKilometers - startKilometers) / liters;
        }

        private double ConsumptionPer100Km()
        {
            return  liters * 100 / (endKilometers - startKilometers);
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            this.liters = this.liters + liters;
            endKilometers = mileage;
        }
    }
}
