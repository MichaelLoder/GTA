using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using GTA.Events.DataSource;

namespace GTA.Events.Services
{
    public class PlayerStatusService : BaseScript
    {
        public PlayerStatusService()
        {
            Tick += OnTick;
        }

        private async Task OnTick()
        {
            PlayerPed.UpdatePlayerStatus();
            await Delay(10);
        }
    }
}
