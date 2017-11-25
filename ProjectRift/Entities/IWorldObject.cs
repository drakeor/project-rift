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

        int GetFuel();
        int GetMaxFuel();
        
        bool ProcessDamage(int general, int shieldDam, int bleedThruDamage);

        bool Update(float deltaTime);
        void Render(float deltaTime);
    }
}
