﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Characters_Bank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int charId { get; set; }
        public int accountNumber { get; set; }
        public int money { get; set; }
        public int pin { get; set; }
        public bool mainAccount { get; set; }
        public bool closed { get; set; }
        public int pinTrys { get; set; }
        public string createZone { get; set; }
    }
}
