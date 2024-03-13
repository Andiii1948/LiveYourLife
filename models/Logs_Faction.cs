using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Logs_Faction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int factionId { get; set; }
        public int charId { get; set; }
        public int targetCharId { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public DateTime timestamp { get; set; }
    }
}
