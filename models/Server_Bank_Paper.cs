using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Bank_Paper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int accountNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string ToOrFrom { get; set; }
        public string TransactionMessage { get; set; }
        public string moneyAmount { get; set; }
        public string zoneName { get; set; }
    }
}
