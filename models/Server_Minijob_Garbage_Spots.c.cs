﻿using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Minijob_Garbage_Spots
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int routeId { get; set; }
        public int spotId { get; set; }
        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }

        [NotMapped]
        public IColShape destinationColshape { get; set; }
    }
}
