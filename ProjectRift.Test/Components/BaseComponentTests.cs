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
        public void GetBaseValueTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetBaseValue());
        }

        /// <summary>
        /// Must be greater than zero
        /// </summary>
        [Test()]
        public void GetCargoSizeTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetCargoSize());
        }

        /// <summary>
        /// Needs a default description
        /// </summary>
        [Test()]
        public void GetDescriptionTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetDescription().Length);
        }

        /// <summary>
        /// Needs a default name
        /// </summary>
        [Test()]
        public void GetNameTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreNotEqual(0, baseComponent.GetName().Length);
        }

        /// <summary>
        /// Has no modifier by default
        /// </summary>
        [Test()]
        public void CalculateArmorTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreEqual(0, baseComponent.GetArmorModifier());
        }

        /// <summary>
        /// Has no modifier by default
        /// </summary>
        [Test()]
        public void CalculateHealthTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreEqual(0, baseComponent.GetArmorModifier());
        }

        /// <summary>
        /// Has no modifier by default
        /// </summary>
        [Test()]
        public void CalculateShieldTest()
        {
            BaseModule baseComponent = new BaseModule();
            Assert.AreEqual(0, baseComponent.GetArmorModifier());
        }
    }
}