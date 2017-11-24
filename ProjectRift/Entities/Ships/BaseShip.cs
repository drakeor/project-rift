using ProjectRift.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Entities.Ships
{
    public class BaseShip : IShip
    {
        protected List<IModule> modules = new List<IModule>();
        int currentHealth;
        int currentArmor;
        int currentShields;

        public BaseShip()
        {
            currentHealth = GetMaxHealth();
            currentArmor = GetMaxArmor();
            currentShields = GetMaxShield();
        }

        public bool AddModule(IModule module)
        {
            if(HasCargoSpace(module.GetCargoSize()))
            {
                modules.Add(module);
                return true;
            }
            return false;
        }

        public int GetArmor()
        {
            return currentArmor;
        }

        public long GetBaseValue()
        {
            return 100;
        }

        public int GetCargoSize()
        {
            return 100;
        }

        public int GetCurrentCargoSpace()
        {
            var currentCount = 0;
            modules.ForEach(x => currentCount += x.GetCargoSize());
            return currentCount;
        }

        public string GetDescription()
        {
            return "No Description";
        }

        public int GetHealth()
        {
            return currentHealth;
        }

        public virtual int GetMaxArmor()
        {
            return 100;
        }

        public virtual int GetMaxCargoSpace()
        {
            return 10;
        }

        public virtual int GetMaxHealth()
        {
            return 100;
        }

        public virtual int GetMaxShield()
        {
            return 100;
        }

        public string GetName()
        {
            return "Unnamed";
        }

        public int GetShield()
        {
            return currentShields;
        }

        public bool HasCargoSpace(int requestedSize)
        {
            return ((requestedSize + GetCurrentCargoSpace()) <= GetMaxCargoSpace());
        }

        public bool ProcessDamage(int general, int shieldDam, int bleedThruDamage)
        {
            // Keep shields at 0 or above.
            // No bleedthru from shield-only weapons
            currentShields -= shieldDam;
            currentShields = Math.Max(0, currentShields);

            // General damage bled thru shield
            var dShieldHealth = general - currentShields;
            if(dShieldHealth > 0)
            {
                general = general - currentShields;
                currentShields = 0;
            }
            // Shields absorbed the full impact
            else
            {
                currentShields = currentShields - general;
                general = 0;
            }

            // Sum remaining damage
            var hullDamage = bleedThruDamage + general;

            // Impact armor first
            var dHealth = hullDamage - currentArmor;
            currentArmor -= hullDamage;
            currentArmor = Math.Max(0, currentArmor);

            // If some damage leaked through the armor, affect the hull
            // Hull can go negative to show how screwed they are
            if(dHealth > 0)
                currentHealth -= dHealth;

            // Ship dies if health drops below 0
            if (currentHealth <= 0)
                return false;

            return true;
        }
    }
}
