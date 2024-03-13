using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Factories
{
    public class ClassicColshape : Checkpoint
    {
        public int ColshapeId { get; set; } = 0;
        public string ColshapeName { get; set; } = "None";
        public string CarDealerVehName { get; set; }
        public ulong CarDealerVehPrice { get; set; }
        public float Radius { get; set; }


        public ClassicColshape(IntPtr nativePointer) : base(nativePointer)
        {

        }

        public bool IsInRange(ClassicPlayer player)
        {
            lock (player)
            {
                if (!player.Exists) return false;

                return player.Position.Distance(Position) <= Radius;
            }
        }
    }
}
