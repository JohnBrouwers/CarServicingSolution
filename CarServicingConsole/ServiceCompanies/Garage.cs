using CarServicingConsole.ServiceCompanies;
using CarServicingConsole.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServicingConsole.Services
{
    class Garage
    {
        public void PerformMaintenance(Car car)
        {
            car.Maintenance.Register("Spark plugs replaced");
            car.Maintenance.Register("Engine oil refreshed");

            WindowService(car);

            car.Maintenance.Register("Interior cleaned");
            car.Maintenance.Register("Washed and polished");
        }

        public CarService WindowService { get; set; }

    }
}
