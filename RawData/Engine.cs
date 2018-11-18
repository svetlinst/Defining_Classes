using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public int engineSpeed { get; set; }
        public int enginePower { get; set; }

        public Engine(int speed, int power)
        {
            this.enginePower = power;
            this.engineSpeed = speed;
        }

    }
}
