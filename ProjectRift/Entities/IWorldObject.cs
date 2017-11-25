using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities
{
    public interface IWorldObject : IBasicObject
    {
        int GetHealth();
        int GetMaxHealth();

        int GetArmor();
        int GetMaxArmor();

        int GetShield();
        int GetMaxShield();

        int GetEnergy();
        int GetMaxEnergy();

        bool ProcessDamage(int general, int shieldDam, int bleedThruDamage);
    }
}
