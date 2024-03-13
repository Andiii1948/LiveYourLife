using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net;
using LiveYourLife.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveYourLife.models;

namespace LiveYourLife.Model
{
    class ServerATM
    {
        public static List<Server_ATM> ServerATM_ = new List<Server_ATM>();

        public static void CreateNewATM(IPlayer client, int maxmoney, Position pos, string zoneName)
        {
            if (client == null || !client.Exists) return;
            var ServerATMData = new Server_ATM
            {
                posX = pos.X,
                posY = pos.Y,
                posZ = pos.Z,
                zoneName = zoneName
            };

            try
            {
                ServerATM_.Add(ServerATMData);
                using (gtaContext db = new gtaContext())
                {
                    db.Server_ATM.Add(ServerATMData);
                    db.SaveChanges();
                }

                HUDHandler.SendNotification(client, 2, 5000, $"ATM in der Zone ({ServerATMData.zoneName}) an deiner Position erstellt.");

                foreach (IPlayer player in Alt.Server.GetPlayers())
                {
                    if (player == null || !player.Exists) return;
                    player.EmitLocked("Client:ServerBlips:AddNewBlip", "Bankautomat", 2, 0.8, true, 277, pos.X, pos.Y, pos.Z);
                }
            }
            catch (Exception e)
            {
                Alt.Log($"{e}");
            }
        }
    }
}
