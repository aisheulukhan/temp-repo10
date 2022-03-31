using ClassTask4IWell.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask4IWell.Models
{
    class Bicycle : IWeel, ITransmission
    {
        public int PedalKind { get; set; }
        public int WingLength { get; set; }
        public bool TransmissionKind { get; set; }
    }
}
