using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Tablet_Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int charId { get; set; }
        public string title { get; set; }
        public string ownerName { get; set; }
        public string callnumber { get; set; }
        public string location { get; set; }
        public string eventtype { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string info { get; set; }
        public DateTime created { get; set; }
    }
}
