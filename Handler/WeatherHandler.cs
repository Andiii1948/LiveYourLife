using AltV.Net.Elements.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveYourLife.Handler
{
    class WeatherHandler
    {
        public static void SetRealTime(IPlayer player)
        {
            if (player == null || !player.Exists) return;
            player.SetDateTime(DateTime.Now);
        }
    }
}
