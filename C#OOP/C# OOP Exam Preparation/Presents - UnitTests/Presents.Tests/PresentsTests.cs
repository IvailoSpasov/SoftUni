using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Presents.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PresentsTests
    {
        [Test]
        public void CreateMethodShouldAddPresentToCollection()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 1);
            bag.Create(present);
            Assert.AreEqual(1,bag.GetPresents().Count);
        }

        [Test]
        public void CreateMethodShouldReturnCorrectStringMessage()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 1);
            string result = bag.Create(present);
            Assert.AreEqual("Successfully added present name.",result);
        }

        [Test]
        public void CreateMethodShouldThrowExceptionWhenTryToAddNull()
        {
            Bag bag = new Bag();
            Present present = null;
            Assert.Throws<ArgumentNullException>(() => bag.Create(present));
        }
        [Test]
        public void CreateMethodShouldThrowExceptionWhenTryToCreatePresentWitchAlreadyExist()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 1);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void RemoveMethodShouldReturnTrueWhenSuccessfullyDeletePresent()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 1);
            bag.Create(present);
            bool result = bag.Remove(present);
            Assert.True(result);
        }
        [Test]
        public void RemoveMethodShouldReturnFalseWhenPresentDontExist()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 1);
            bool result = bag.Remove(present);
            Assert.False(result);
        }

        [Test]
        public void GetPresentWithLeastMagicShouldWorkProperly()
        {
            Bag bag = new Bag();
            Present firstPresent = new Present("first", 1);
            Present secondPresent = new Present("second", 2);
            bag.Create(firstPresent);
            bag.Create(secondPresent);
            Present result = bag.GetPresentWithLeastMagic();
            Assert.AreEqual(1,result.Magic);
        }

        [Test]
        public void GetPresentsMethodShouldReturnReadOnlyCollection()
        {
            Bag bag = new Bag();
            var result = bag.GetPresents();
            Assert.True(result is IReadOnlyCollection<Present>);
        }

        [Test]
        public void GetPresentMethodShouldReturnNullWhenPresentIsNotFound()
        {
            Bag bag = new Bag();
            Assert.AreEqual(null,bag.GetPresent("name"));
        }
        [Test]
        public void GetPresentMethodShouldReturnPresentWithGivenName()
        {
            Bag bag = new Bag();
            Present present = new Present("name", 1);
            bag.Create(present);
            var result = bag.GetPresent("name");
            Assert.AreEqual(present, result);
        }
    }
}
