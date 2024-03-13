using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Farming_Producer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }
        public float pedRotation { get; set; }
        public string pedModel { get; set; }
        public string neededItem { get; set; }
        public string producedItem { get; set; }
        public float range { get; set; }
        public int duration { get; set; }
        public int neededItemAmount { get; set; }
        public int producedItemAmount { get; set; }
        public string blipName { get; set; }
        public bool isBlipVisible { get; set; }
    }
}
