using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public class Logs_Death
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }
        public int playerName { get; set; }
        public int killerName { get; set; }
        public uint weaponId { get; set; }
        public DateTime timestamp { get; set; }
    }
}
