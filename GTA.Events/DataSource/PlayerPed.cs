using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using GTA.Events.Helpers;

namespace GTA.Events.DataSource
{
    public static class PlayerPed
    {
        public static int PreviousTickHealth;
        public static string PlayerName => Game.Player.Name;
        public static int PlayerHealth => Game.PlayerPed.Health;
        public static Vehicle PlayerDamagedByVehicle => VehicleHelpers.VehicleThatCausedDamage();
        public static bool HasPlayerLostHealth => PlayerHealth < PreviousTickHealth;
        public static WeaponHash CurrentWeaponHash => GetCurrentWeapon();

        public static void UpdatePlayerStatus()
        {
            PreviousTickHealth = PlayerHealth;
        }

        private static WeaponHash GetCurrentWeapon()
        {
            foreach (var weapon in Enum.GetValues(typeof(WeaponHash)))
            {
                if ((WeaponHash)API.GetSelectedPedWeapon(API.GetPlayerPed(-1)) == (WeaponHash)weapon)
                {
                    Debug.WriteLine($"Player shooting {weapon}");
                    return (WeaponHash) weapon;
                }
            }
            return WeaponHash.Unarmed;
        }
    }
}
