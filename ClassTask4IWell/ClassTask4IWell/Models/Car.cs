using ClassTask4IWell.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask4IWell.Models
{
    class Car : IEngine, IWeel, ITransmission
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public bool TransmissionKind { get; set; }
        public double HorsePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TankSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
