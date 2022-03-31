using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask4IWell.Interface
{
    interface IEngine
    {
        public double HorsePower { get; set; }
        public int TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

        public void LeftFuelAmount()
        {

        }

    }
}
