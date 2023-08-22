using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Morgan_Daniel
{/// <summary>
/// Class named Sedan that implements the IAutomobile interface, and adds a private setter to the Speed property 
/// </summary>
    class Sedan : IAutomobile 
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }
        // This set wheels to 4, Speed to speed and LicensePlate to GCTC-06
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }
        // Public void  Stringify method that prints to the console
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }
        /// <summary>
        /// Two methods that will increase and decrease the speed of the Sedan by 5 when called
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
