using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Wanteds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int wantedId { get; set; }

        public int category { get; set; }
        public string wantedName { get; set; }
        public int paragraph { get; set; }
        public int jailtime { get; set; }
        public int ticketfine { get; set; }
    }
}
