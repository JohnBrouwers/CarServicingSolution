using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServicingConsole.Vehicles
{
    class Maintenance
    {
        private string type;
        public Maintenance(string type)
        {
            this.type = type;
            this.MaintenanceList = new List<string>();
        }

        private List<string> MaintenanceList { get; set; }
        public void Register(string description)
        {
            this.MaintenanceList.Add($"\t{DateTime.Now.ToShortDateString()} : {description}\n");
        }
        public string Booklet
        {
            get
            {
                return $"{type} maintenance booklet \n\n{string.Concat(this.MaintenanceList)}";
            }
        }
    }
}
