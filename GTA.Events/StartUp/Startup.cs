using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace GTA.Events.StartUp
{
    public class Startup : BaseScript
    {
        public Startup()
        {
            LoadConfig();
        }
        public static Config Config { get; private set; }
        public static void LoadConfig()
        {
            Config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("/Config.json"));
        }
    }
}
