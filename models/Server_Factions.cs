using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Factions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string factionName { get; set; }
        public string factionShort { get; set; }
        public int factionMoney { get; set; }
        public int phoneNumber { get; set; }

        [NotMapped]
        public int currentPhoneOwnerId { get; set; } = 0;
    }
}
