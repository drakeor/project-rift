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

        int baseMaxShields;
        int baseMaxArmor;
        int baseMaxHealth;

        int currentHealth;
        int currentArmor;
        int currentShields;

        public BaseShip()
        {
            Initialize(100, 100, 100);
        }

        public BaseShip(int maxShields, int maxArmor, int maxHealth)
        {
            Initialize(maxShields, maxArmor, maxHealth);
        }

        private void Initialize(int maxShields, int maxArmor, int maxHealth)
        {
            this.baseMaxShields = maxShields;
            this.baseMaxArmor = maxArmor;
            this.baseMaxHealth = maxHealth;

            currentHealth = maxShields;
            currentArmor = maxArmor;
            currentShields = maxHealth;
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

        public int GetMaxArmor()
        {
            return baseMaxArmor;
        }

        public int GetMaxCargoSpace()
        {
            return 10;
        }

        public int GetMaxHealth()
        {
            return baseMaxHealth;
        }

        public int GetMaxShield()
        {
            return baseMaxShields;
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
            // Max damage allowed is 1 billion
            general = Math.Min(general, 1000000000);
            shieldDam = Math.Min(shieldDam, 1000000000);
            bleedThruDamage = Math.Min(bleedThruDamage, 1000000000);

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
