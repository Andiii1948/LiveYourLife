using AltV.Net.Elements.Entities;
using LiveYourLife.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Model
{
    class ServerDoors
    {
        public static List<Server_Doors> ServerDoors_ = new List<Server_Doors>();
        public static List<IColShape> ServerDoorsColshapes_ = new List<IColShape>();
        public static List<IColShape> ServerDoorsLockColshapes_ = new List<IColShape>();
    }
}
