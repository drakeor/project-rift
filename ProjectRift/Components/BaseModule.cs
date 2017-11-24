using ProjectRift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public class BaseModule : IModule
    {
        public long GetBaseValue()
        {
            return 1000;
        }

        public int GetCargoSize()
        {
            return 1;
        }

        public virtual string GetDescription()
        {
            return "No Description";
        }

        public virtual string GetName()
        {
            return "Unnamed";
        }

        public virtual int CalculateArmorDamage(int baseValue, int currentValue)
        {
            return currentValue;
        }

        public virtual int CalculateHealthDamage(int baseValue, int currentValue)
        {
            return currentValue;
        }

        public virtual int CalculateShieldDamage(int baseValue, int currentValue)
        {
            return currentValue;
        }
    }
}
