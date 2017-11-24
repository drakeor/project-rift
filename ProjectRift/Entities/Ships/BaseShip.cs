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

        public int GetMaxArmor()
        {
            return 100;
        }

        public virtual int GetMaxCargoSpace()
        {
            return 10;
        }

        public int GetMaxHealth()
        {
            return 100;
        }

        public int GetMaxShield()
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

        public bool ProcessDamage(int general, int shieldDam, int armorDam, int hullDam)
        {
            // Keep shields at 0 or above
            currentShields -= shieldDam;
            currentShields = Math.Max(0, currentShields);

            // Keep armor at 0 or above
            currentArmor -= armorDam;
            currentArmor = Math.Max(0, currentArmor);

            // Hull can go negative to show how screwed they are
            currentHealth -= hullDam;

            if (currentHealth <= 0)
                return true;

            return false;
        }
    }
}
