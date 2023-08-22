using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Morgan_Daniel
{
    internal interface IAutomobile // Interface call IAutomobile
    {

        public double Speed { get; } // Double property called Speed with an automatic getter

        public int Wheels { get; } // Public in property called Wheels with an automatic getter

        public string LicensePlate { get; } // Public string property called LicensePlate with an automatic getter

        public void Stringify(); // Void method called Stringify

    }
}
