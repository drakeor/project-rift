using ProjectRift.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components
{
    public interface IModule : IBasicObject
    {
        int CalculateShieldDamage(int baseValue, int currentValue);
        int CalculateArmorDamage(int baseValue, int currentValue);
        int CalculateHealthDamage(int baseValue, int currentValue);
    }
}
