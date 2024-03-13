﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Server_Clothes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string clothesName { get; set; }
        public string type { get; set; }
        public int draw { get; set; }
        public int texture { get; set; }
        public int gender { get; set; }
        public int faction { get; set; }
    }
}
