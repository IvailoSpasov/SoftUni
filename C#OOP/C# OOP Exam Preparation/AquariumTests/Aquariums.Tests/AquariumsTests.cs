using NUnit.Framework;

namespace Aquariums.Tests
{
    using System;
    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("name", 3);

            Assert.AreEqual("name",aquarium.Name);
            Assert.AreEqual(3,aquarium.Capacity);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium("", 3));
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenCapacityIsNegativeNumber()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("name", -3));
        }

        [Test]
        public void AddMethodShouldAddFishToCollection()
        {
            Aquarium aquarium = new Aquarium("name", 3);
            Fish fish = new Fish("petko");

            aquarium.Add(fish);

            Assert.AreEqual(1,aquarium.Count);
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenCapacityIsFull()
        {
            Aquarium aquarium = new Aquarium("name", 1);
            Fish fish = new Fish("petko");
            Fish fish1 = new Fish("gogo");

            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(fish1));
        }

        [Test]
        public void RemoveMethodShouldRemoveFishFromCollection()
        {
            Aquarium aquarium = new Aquarium("name", 3);
            Fish fish = new Fish("petko");
            Fish fish1 = new Fish("gogo");

            aquarium.Add(fish);
            aquarium.Add(fish1);
            aquarium.RemoveFish("gogo");

            Assert.AreEqual(1,aquarium.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWhenFishDoesNotExist()
        {
            Aquarium aquarium = new Aquarium("name", 3);
            Fish fish = new Fish("petko");
            Fish fish1 = new Fish("gogo");

            aquarium.Add(fish);
            aquarium.Add(fish1);

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("dimo"));
        }

        [Test]
        public void SellFishMethodShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("name", 3);
            Fish fish = new Fish("petko");
            Fish fish1 = new Fish("gogo");

            aquarium.Add(fish);
            aquarium.Add(fish1);

            Fish soldFish = aquarium.SellFish("petko");

            Assert.False(soldFish.Available);
        }
        [Test]
        public void SellFishMethodShouldThrowExceptionWhenFishDoesNotExist()
        {
            Aquarium aquarium = new Aquarium("name", 3);
            Fish fish = new Fish("petko");
            Fish fish1 = new Fish("gogo");

            aquarium.Add(fish);
            aquarium.Add(fish1);

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("dimo"));
        }

        [Test]
        public void ReportMethodShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("name", 3);
            Fish fish = new Fish("petko");
            Fish fish1 = new Fish("gogo");

            aquarium.Add(fish);
            aquarium.Add(fish1);

            string report = aquarium.Report();
            string expected = $"Fish available at name: petko, gogo";

            Assert.AreEqual(expected,report);
        }
    }
}
