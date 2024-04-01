using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2024.Models
{
    internal class ElectricCar : Car1
    {
        private int _battery = 100;
        public int Battery
        {
            get => _battery;
            protected set
            {
                if (value < 0)
                {
                    Console.WriteLine("Battery empty");
                    _battery = 0;
                }
                else
                {
                    _battery = value;
                }
            }
        }
    }
}
