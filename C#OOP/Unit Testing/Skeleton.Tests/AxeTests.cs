using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Test_Axe_Loses_Durability_After_Attack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9,axe.DurabilityPoints);
        }

        [Test]
        public void Test_With_Broken_Axe()
        {
            Axe axe = new Axe(5, 0);
            Dummy dummy = new Dummy(10, 10);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}