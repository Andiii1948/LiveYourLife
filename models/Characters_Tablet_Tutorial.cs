﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Characters_Tablet_Tutorial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int charId { get; set; }
        public bool openTablet { get; set; }
        public bool openInventory { get; set; }
        public bool createBankAccount { get; set; }
        public bool buyVehicle { get; set; }
        public bool useGarage { get; set; }
        public bool acceptJob { get; set; }
    }
}