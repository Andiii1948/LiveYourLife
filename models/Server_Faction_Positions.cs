using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Faction_Positions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int factionId { get; set; }
        public string posType { get; set; } //storage | duty | manage
        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }
        public float rotation { get; set; }
    }
}
