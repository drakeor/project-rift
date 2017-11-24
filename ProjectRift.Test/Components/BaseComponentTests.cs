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
        [Test()]
        public void BaseComponent_BaseComponentTest()
        {
            BaseComponent baseComponent = new BaseComponent();
        }

        /// <summary>
        /// Must be greater than zero
        /// </summary>
        [Test()]
        public void BaseComponent_GetBaseValueTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreNotEqual(0, baseComponent.GetBaseValue());
        }

        /// <summary>
        /// Must be greater than zero
        /// </summary>
        [Test()]
        public void BaseComponent_GetCargoSizeTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreNotEqual(0, baseComponent.GetCargoSize());
        }

        /// <summary>
        /// Needs a default description
        /// </summary>
        [Test()]
        public void BaseComponent_GetDescriptionTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreNotEqual(0, baseComponent.GetDescription().Length);
        }

        /// <summary>
        /// Needs a default name
        /// </summary>
        [Test()]
        public void BaseComponent_GetNameTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreNotEqual(0, baseComponent.GetName().Length);
        }

        /// <summary>
        /// Passthru ONLY the current value
        /// </summary>
        [Test()]
        public void BaseComponent_CalculateArmorDamageTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreEqual(100, baseComponent.CalculateArmorDamage(50, 100));
        }

        /// <summary>
        /// Passthru ONLY the current value
        /// </summary>
        [Test()]
        public void BaseComponent_CalculateHealthDamageTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreEqual(100, baseComponent.CalculateArmorDamage(50, 100));
        }

        /// <summary>
        /// Passthru ONLY the current value
        /// </summary>
        [Test()]
        public void BaseComponent_CalculateShieldDamageTest()
        {
            BaseComponent baseComponent = new BaseComponent();
            Assert.AreEqual(100, baseComponent.CalculateArmorDamage(50, 100));
        }
    }
}