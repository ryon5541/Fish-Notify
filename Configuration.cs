using Dalamud.Configuration;
using Dalamud.Plugin;
using System;
namespace FishNotify
{
    internal class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;
        public bool ChatAlerts { get; set; } = false;
        [NonSerialized]
        private DalamudPluginInterface pluginInterface = null!;
        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
        }
        public void Save()
        {
            this.pluginInterface.SavePluginConfig(this);
        }
    }
}