﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Goood morning vietnaaam shhshshshs, you are listening to NHR");
        }
    }
}
