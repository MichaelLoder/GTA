using System;
using CitizenFX.Core;

namespace GTA.Common.Models.Events
{
    public class PlayerDamagedByVehicleEventArgs : EventArgs
    {
        public Ped Player { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
