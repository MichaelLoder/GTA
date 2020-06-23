using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace GTA.Events.Helpers
{
    public class DamageHelpers
    {
        public static bool PedDamagedByVehicle(Vehicle playerVehicle, Ped player)
        {
            return player.HasBeenDamagedBy(playerVehicle);
        }
    }
}
