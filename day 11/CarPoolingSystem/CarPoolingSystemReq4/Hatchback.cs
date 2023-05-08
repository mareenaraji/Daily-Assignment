using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystemReq4
{
    class Hatchback:Car
    {
        private bool _powerWindows;

        public bool PowerWindows
        {
            get { return _powerWindows; }
            set { _powerWindows = value; }
        }
        private bool _automaticGear;

        public bool AutomaticGear
        {
            get { return _automaticGear; }
            set { _automaticGear = value; }
        }

        public Hatchback() { }

        // Constructor

        public Hatchback(long id, string name, 
            bool powerWindows, 
            bool automaticGear):base(id,name)

        {
            this._powerWindows = powerWindows;
            this._automaticGear = automaticGear;

        }

        // Implementing abstract method from Car class

        public override double CalculateDriveCost(double km)

        {

            double cost = 0;

            if (AutomaticGear==true)

                cost = 12*km;

            else

                cost = 10*km;

            return cost;

        }

    }
}
