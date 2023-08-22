using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Morgan_Daniel
{   /// <summary>
/// Includes all the properties from the IAutomobile interface and an additional double property called Weight with an automatic getter
/// </summary>
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }
        /// <summary>
        /// sets Speed to speed , Weight to weight, and LicensePlate to licenseNum in the constructor 
        /// </summary>
        /// <param name="speedParam"></param>
        /// <param name="weightParam"></param>
        /// <param name="licenseNum"></param>
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;
            
            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        // Prints to the console
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }
        /// <summary>
        /// These should increase and decrease the speed of the truck
        /// </summary>
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
