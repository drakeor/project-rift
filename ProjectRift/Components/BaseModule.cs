using ProjectRift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public class BaseModule : IBasicObject, IModule
    {
        public BaseModule()
        {

        }

        public long GetBaseValue()
        {
            return 1000;
        }

        public int GetCargoSize()
        {
            return 1;
        }

        public string GetDescription()
        {
            return "No Description";
        }

        public string GetName()
        {
            return "Unnamed";
        }

        public int CalculateArmorDamage(int baseValue, int currentValue)
        {
            return currentValue;
        }

        public int CalculateHealthDamage(int baseValue, int currentValue)
        {
            return currentValue;
        }

        public int CalculateShieldDamage(int baseValue, int currentValue)
        {
            return currentValue;
        }
    }
}
