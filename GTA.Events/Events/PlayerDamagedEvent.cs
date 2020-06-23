using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using GTA.Common.Models.Events;
using GTA.Events.DataSource;
using GTA.Events.StartUp;

namespace GTA.Events.Events
{
    public class PlayerDamagedEvent : BaseScript
    {
        public PlayerDamagedEvent()
        {
            Tick += OnTick;
        }

        private async Task OnTick()
        {
            try
            {
                var vehicleThatDamage = PlayerPed.PlayerDamagedByVehicle;
                if (vehicleThatDamage != null)
                {
                    #if DEBUG
                    Debug.WriteLine($"Player hit by { CitizenFX.Core.Native.API.NetworkGetPlayerIndexFromPed(vehicleThatDamage.Driver.NetworkId)}");
                    #endif
                    TriggerServerEvent("PlayerDamageByVehicle", new PlayerDamagedByVehicleEventArgs()
                    {
                        Player = Game.PlayerPed,
                        Vehicle = vehicleThatDamage
                    });
                }
                await Delay(10);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            
        }
    }
}
