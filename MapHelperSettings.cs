using System.Windows.Forms;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace MapHelper
{
    public class MapHelperSettings : ISettings
    {
        public MapHelperSettings()
        {
            Enable = new ToggleNode(false);
            MapHelperKey = Keys.F5;

            EleReflect = new ToggleNode(true);
            RedBlock = new ToggleNode(true);
            NoRegen = new ToggleNode(true);
            //NoRegenValue = new RangeNode<float>(60, 0, 100);

        }

        public ToggleNode Enable { get; set; }
        public HotkeyNode MapHelperKey { get; set; }

        public ToggleNode PhysicalReflect { get; set; }
        public ToggleNode ReducedBlock { get; set; }
        public ToggleNode NoRegen { get; set; }
        //public RangeNode<float>NoRegenValue { get; set; } 


    }
}
