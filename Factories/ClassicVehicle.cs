using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Factories
{
    public class ClassicVehicle : Vehicle
    {
        public int VehicleId { get; set; }
        public bool Trunkstate { get; set; } = false;

        public ClassicVehicle(IntPtr nativePointer, ushort id) : base(nativePointer, id)
        {
        }

        public ClassicVehicle(uint model, Position position, Rotation rotation) : base(model, position, rotation)
        {
        }
    }
}
