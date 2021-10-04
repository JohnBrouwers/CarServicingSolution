using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServicingConsole.Vehicles
{
    class Car
    {
        public string Make { get; set; }
        public Maintenance Maintenance { get; }

        public Car(string make)
        {
            Make = make;
            Maintenance = new Maintenance(Make);
        }

    }
}
