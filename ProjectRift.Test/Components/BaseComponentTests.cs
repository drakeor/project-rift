using NUnit.Framework;
using ProjectRift.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRift.Components.Tests
{
    [TestFixture()]
    public class BaseComponentTests
    {
        /// <summary>
        /// Must be greater than zero
        /// </summary>
        [Test()]
        public void BaseComponent_GetBaseValueTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetBaseValue());
        }

        /// <summary>
        /// Must be greater than zero
        /// </summary>
        [Test()]
        public void BaseComponent_GetCargoSizeTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetCargoSize());
        }

        /// <summary>
        /// Needs a default description
        /// </summary>
        [Test()]
        public void BaseComponent_GetDescriptionTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetDescription().Length);
        }

        /// <summary>
        /// Needs a default name
        /// </summary>
        [Test()]
        public void BaseComponent_GetNameTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetName().Length);
        }

        /// <summary>
        /// Passthru ONLY the current value
        /// </summary>
        [Test()]
        public void BaseComponent_CalculateArmorDamageTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreEqual(100, baseComponent.CalculateArmorDamage(50, 100));
        }

        /// <summary>
        /// Passthru ONLY the current value
        /// </summary>
        [Test()]
        public void BaseComponent_CalculateHealthDamageTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreEqual(100, baseComponent.CalculateArmorDamage(50, 100));
        }

        /// <summary>
        /// Passthru ONLY the current value
        /// </summary>
        [Test()]
        public void BaseComponent_CalculateShieldDamageTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreEqual(100, baseComponent.CalculateArmorDamage(50, 100));
        }
    }
}