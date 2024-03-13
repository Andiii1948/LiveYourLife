using AltV.Net.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class ServerFaction_Dispatch
    {
        public int senderCharId { get; set; }
        public int factionId { get; set; }
        public string message { get; set; }
        public string Date { get; set; }
        public Position Destination { get; set; }
    }
}
