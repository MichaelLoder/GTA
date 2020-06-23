using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace GTA.Events.Helpers
{
    public static class VehicleHelpers
    {
        public static IEnumerable<Vehicle> GetPlayerVehicles()
        {
            return World.GetAllVehicles().Where(x => x.Driver.IsHuman);
        }

        public static Vehicle VehicleThatCausedDamage()
        {
            return GetPlayerVehicles().FirstOrDefault(playerVehicle => DamageHelpers.PedDamagedByVehicle(playerVehicle, Game.PlayerPed));
        }
    }
}
