using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Factories
{
    public class VehicleFactory : IEntityFactory<IVehicle>
    {
        public IVehicle Create(uint model, Position position, Rotation rotation)
        {
            return new ClassicVehicle(model, position, rotation);
        }

        public IVehicle Create(IntPtr nativePointer, ushort id)
        {
            return new ClassicVehicle(nativePointer, id);
        }
    }

    public class AccountsFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(IntPtr playerPointer, ushort id)
        {
            return new ClassicPlayer(playerPointer, id);
        }
    }

    public class ColshapeFactory : IBaseObjectFactory<IColShape>
    {
        public IColShape Create(IntPtr entityPointer)
        {
            return new ClassicColshape(entityPointer);
        }
    }
}
