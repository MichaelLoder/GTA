using CitizenFX.Core;

namespace GTA.Common.Models.Events
{
    public class PlayerHasShotEventArgs
    {
        public Ped Player { get; set; }
        public WeaponHash Weapon { get; set; }
        public Vector3 Location { get; set; }
    }
}
