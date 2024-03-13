using LiveYourLife.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Model
{
    class ServerBlips
    {
        public static List<Server_Blips> ServerBlips_ = new List<Server_Blips>();
        public static List<Server_Markers> ServerMarkers_ = new List<Server_Markers>();

        public static string GetAllServerBlips()
        {
            var items = ServerBlips_.Select(x => new
            {
                x.name,
                x.color,
                x.scale,
                x.shortRange,
                x.sprite,
                x.posX,
                x.posY,
                x.posZ,
            }).ToList();

            return JsonConvert.SerializeObject(items);
        }

        public static string GetAllServerMarkers()
        {
            var items = ServerMarkers_.Select(x => new
            {
                x.type,
                x.posX,
                x.posY,
                x.posZ,
                x.scaleX,
                x.scaleY,
                x.scaleZ,
                x.red,
                x.green,
                x.blue,
                x.alpha,
                x.bobUpAndDown,
            }).ToList();

            return JsonConvert.SerializeObject(items);
        }
    }
}
