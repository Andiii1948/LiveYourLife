using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Garages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string name { get; set; }
        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }
        public float rotation { get; set; }
        public int type { get; set; } //0 Auto | 1 Boot | 2 Flugzeug | 3 Heli
        public bool isBlipVisible { get; set; }
    }
}
