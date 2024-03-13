using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_All_Vehicles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string category { get; set; }
        public string manufactor { get; set; }
        public string name { get; set; }
        public ulong hash { get; set; }
        public int price { get; set; }
        public int trunkCapacity { get; set; }
        public int maxFuel { get; set; }
        public string fuelType { get; set; }
        public int seats { get; set; }
        public int tax { get; set; } //Fahrzeugsteuer
        public int vehClass { get; set; } //0 Auto - 1 Boot - 2 Flugzeug - 3 Helikopter
    }
}
