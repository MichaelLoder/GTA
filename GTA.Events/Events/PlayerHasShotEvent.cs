using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using GTA.Common.Models.Events;
using GTA.Events.DataSource;
using GTA.Events.StartUp;

namespace GTA.Events.Events
{
    public class PlayerHasShotEvent : BaseScript
    {
        public PlayerHasShotEvent()
        {
            Tick += OnTick;
        }

        private async Task OnTick()
        {
            if (API.IsPedShooting(API.GetPlayerPed(-1)))
            {
                try
                {
                    #if DEBUG
                    Debug.WriteLine($"Player has shot { PlayerPed.CurrentWeaponHash }");
                #endif
                    var coords = API.GetEntityCoords(API.GetPlayerPed(-1), false);
                    TriggerServerEvent("GunShotEvent", new PlayerHasShotEventArgs()
                    {
                        Player = Game.PlayerPed,
                        Weapon = PlayerPed.CurrentWeaponHash,
                        Location = coords
                    });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Exception{ ex.Message}");
                }
               
            }
            await Delay(10);
        }
    }
}
