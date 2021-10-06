using CarServicingConsole.ServiceCompanies;
using CarServicingConsole.Services;
using CarServicingConsole.Vehicles;
using System;

namespace CarServicingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise:
            //Enable the garage to have the car serviced by a window repair company

            //The program selects the car,
            //  the garage for general maintenance
            //  and the company for window servicing.
            //The garage should control when window service is performed.

            var car = new Car("Mercedes");
            var garage = new Garage();

            var windowService = new CarGlass();
            garage.WindowService = windowService.PerformService;


            garage.PerformMaintenance(car);

            Console.WriteLine(car.Maintenance.Booklet);


            Console.WriteLine("\nPress <ENTER> to exit..");
            Console.ReadLine();
        }
    }
}
