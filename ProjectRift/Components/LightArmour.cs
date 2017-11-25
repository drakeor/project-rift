using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public class LightArmour : BaseModule
    {
        public override string GetName()
        {
            return "Light Armour";
        }

        public override string GetDescription()
        {
            return "Weak Armor";
        }

        public override int GetArmorModifier()
        {
            return 100;
        }

        public override int GetCargoSize()
        {
            return 2;
        }
    }
}
