using CarServicingConsole.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServicingConsole.Services
{
    class AutoTotaalGlas
    {
        public void PerformService(Car car)
        {
            car.Maintenance.Register("Window(s) repaired by Autototaalglas");
        }
    }
}
