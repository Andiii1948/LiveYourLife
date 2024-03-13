using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.models
{
    public partial class Characters_LastPos
    {
        public int charId { get; set; }
        public float lastPosX { get; set; }
        public float lastPosY { get; set; }
        public float lastPosZ { get; set; }
        public int lastDimension { get; set; }
    }
}
