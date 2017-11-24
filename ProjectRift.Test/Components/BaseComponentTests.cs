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
            Assert.AreNotEqual(0, baseComponent.GetBaseValue());
        }

        [Test()]
        public void BaseComponent_GetDescriptionTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void BaseComponent_GetNameTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void BaseComponent_CalculateArmorDamageTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void BaseComponent_CalculateHealthDamageTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void BaseComponent_CalculateShieldDamageTest()
        {
            Assert.Fail();
        }
    }
}