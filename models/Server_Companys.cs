using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Companys
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string companyName { get; set; }
        public int companyOwnerId { get; set; }
        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }
        public string givenLicense { get; set; }
        public DateTime createdTimestamp { get; set; }
        public int companyMoney { get; set; }
    }
}
