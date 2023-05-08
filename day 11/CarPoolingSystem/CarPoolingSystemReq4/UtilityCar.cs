using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq4
{
     class UtilityCar:Car
    {
        public bool RearCoolingVents { get; set; }

        // Constructor

        public UtilityCar(long id, string name, bool rearCoolingVents)

        {

            Id = id;

            Name = name;

            RearCoolingVents = rearCoolingVents;

        }

        // Implementing abstract method from Car class

        public override double CalculateDriveCost(double km)

        {

            return 18 * km;

        }
    }
}
