using System;
using System.Diagnostics;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void Test_If_Dummy_Loses_Health_When_Has_Been_Attacked()
        {
            Dummy dummy = new Dummy(10, 10);
            dummy.TakeAttack(1);
            Assert.AreEqual(9,dummy.Health);
        }

        [Test]
        public void Test_If_Dummy_Throws_Exception_When_Its_Dead_And_Has_Been_Attacked()
        {
            Dummy dummy = new Dummy(0, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
        }

        [Test]
        public void Test_Does_Dummy_Give_Experience()
        {
            Dummy dummy = new Dummy(0, 10);
            int experience = dummy.GiveExperience();
            Assert.AreEqual(10,experience);
        }

        [Test]
        public void Test_Does_Alive_Dummy_Throws_Exception_When_Try_To_Give_His_Experience()
        {
            Dummy dummy = new Dummy(1, 10);
            Assert.Throws<InvalidOperationException>(()=>dummy.GiveExperience());
        }
    }
}