using ProjectRift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public class BaseComponent : IBasicObject, IComponent
    {
        public BaseComponent()
        {

        }

        public long GetBaseValue()
        {
            throw new NotImplementedException();
        }

        public int GetCargoSize()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int CalculateArmorDamage(int baseValue, int currentValue)
        {
            throw new NotImplementedException();
        }

        public int CalculateHealthDamage(int baseValue, int currentValue)
        {
            throw new NotImplementedException();
        }

        public int CalculateShieldDamage(int baseValue, int currentValue)
        {
            throw new NotImplementedException();
        }
    }
}
