using System;
using NUnit.Framework;

namespace Gyms.Tests
{
    [TestFixture]
    public class GymsTests
    {
        [Test]
        public void ConstructorShouldSetNameProperly()
        {
            Gym gym = new Gym("name", 3);
            Assert.AreEqual("name",gym.Name);
        }
        [Test]
        public void ConstructorShouldSetCapacityProperly()
        {
            Gym gym = new Gym("name", 3);
            Assert.AreEqual(3, gym.Capacity);
        }

        [Test]
        public void ShouldThrowExceptionWhenNameIsNull()
        {

            Assert.Throws<ArgumentNullException>(() => new Gym("", 3));
        }

        [Test]
        public void ShouldThrowExceptionWhenCapacityIsNegativeNumber()
        {
            Assert.Throws<ArgumentException>(()=>new Gym("name", -1));
        }

        [Test]
        public void CountShouldWorkProperlyAndGymCanAddAthlete()
        {
            Gym gym = new Gym("name", 4);
            Athlete athlete = new Athlete("athlete");
            gym.AddAthlete(athlete);
            Assert.AreEqual(1,gym.Count);
        }

        [Test]
        public void ShouldThrowExceptionWhenCapacityIsFullAndTryToAddNewAthlete()
        {
            Gym gym = new Gym("name", 1);
            Athlete athlete = new Athlete("athlete");
            Athlete athlete2 = new Athlete("athlete2");
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(athlete2));
        }

        [Test]
        public void CheckIfRemoveMethodWorkProperly()
        {
            Gym gym = new Gym("name", 1);
            Athlete athlete = new Athlete("athlete");
            gym.AddAthlete(athlete);
            gym.RemoveAthlete("athlete");
            Assert.AreEqual(0,gym.Count);
        }

        [Test]
        public void ShouldThrowExceptionWhenRemoveMethodIsInvokeWithNull()
        {
            Gym gym = new Gym("name", 1);
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete(""));
        }

        [Test]
        public void TestIfAthleteInjureMetodWorkProperly()
        {
            Gym gym = new Gym("name", 3);
            Athlete athlete = new Athlete("athlete");
            gym.AddAthlete(athlete);
            athlete=gym.InjureAthlete("athlete");
            Assert.True(athlete.IsInjured);
        }

        [Test]
        public void ShouldThrowExceptionWhenTryToInjureAthleteWithNegativeName()
        {
            Gym gym = new Gym("name", 3);
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("athlete"));
        }

        [Test]
        public void CheckIsReportMethodWorkProperly()
        {
            Gym gym = new Gym("name", 3);
            Athlete athlete = new Athlete("pesho");
            Athlete athlete2 = new Athlete("gosho");
            gym.AddAthlete(athlete);
            gym.AddAthlete(athlete2);
            Assert.AreEqual("Active athletes at name: pesho, gosho",gym.Report());
        }
    }
}
