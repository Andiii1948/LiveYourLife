using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Faction_Members
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int charId { get; set; }
        public int factionId { get; set; }
        public int rank { get; set; }
        public int serviceNumber { get; set; }
        public bool isDuty { get; set; }
        public DateTime lastChange { get; set; }
    }
}
