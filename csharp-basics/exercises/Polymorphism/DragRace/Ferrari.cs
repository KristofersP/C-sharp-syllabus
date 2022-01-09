using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Ferrari : ICar,IBoostable
    {
        private int currentSpeed = 0;
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void SlowDown()
        {
            currentSpeed -= 15;
        }

        public void SpeedUp()
        {
            currentSpeed += 32;
        }



        public string StartEngine()
        {
            return "BRRRRRRRRRRRRRRRRRRRRRRR";
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 30;
        }
    }
}
