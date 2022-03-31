using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask4IWell
{
    abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public void AverageSpeed(double drivepath, double drivetime)
        {
            Console.WriteLine($"Average speed {drivepath/drivetime} ");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Drive time : {DriveTime}  Drive path:  {DrivePath}");
        }
    }
}
