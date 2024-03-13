using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net;
using LiveYourLife.Handler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Model
{
    class ServerPeds
    {
        public static List<Server_Peds> ServerPeds_ = new List<Server_Peds>();

        public static void CreateServerPed(IPlayer client, string model, Position pos, float rotation)
        {
            if (client == null || !client.Exists) return;
            var ServerPedData = new Server_Peds
            {
                model = model,
                posX = pos.X,
                posY = pos.Y,
                posZ = pos.Z,
                rotation = rotation
            };

            try
            {
                ServerPeds_.Add(ServerPedData);

                using (gtaContext db = new gtaContext())
                {
                    db.Server_Peds.Add(ServerPedData);
                    db.SaveChanges();
                }

                HUDHandler.SendNotification(client, 2, 5000, $"Ped mit dem Model ({ServerPedData.model}) an deiner Position erstellt.");
            }
            catch (Exception e)
            {
                Alt.Log($"{e}");
            }
        }

        public static string GetAllServerPeds()
        {
            var items = ServerPeds_.Select(x => new
            {
                model = x.model,
                posX = x.posX,
                posY = x.posY,
                posZ = x.posZ,
                rotation = x.rotation,
            }).ToList();

            return JsonConvert.SerializeObject(items);
        }
    }
}
