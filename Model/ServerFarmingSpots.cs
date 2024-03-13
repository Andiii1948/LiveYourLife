using AltV.Net.Elements.Entities;
using LiveYourLife.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Model
{
    class ServerFarmingSpots
    {
        public static List<Server_Farming_Spots> ServerFarmingSpots_ = new List<Server_Farming_Spots>();
        public static List<Server_Farming_Producer> ServerFarmingProducer_ = new List<Server_Farming_Producer>();
        public static List<IColShape> ServerFarmingSpotsColshapes_ = new List<IColShape>();
        public static List<IColShape> ServerFarmingProducerColshapes_ = new List<IColShape>();
    }
}
