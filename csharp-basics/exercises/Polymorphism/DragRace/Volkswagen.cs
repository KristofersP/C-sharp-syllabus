using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Volkswagen : ICar
    {
        private int currentSpeed = 0;
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
        }

        public void SpeedUp()
        {
            currentSpeed += 17;
        }

        public string StartEngine()
        {
            return "Pra....pra...pra..praparprapraparpra";
        }
    }
}
