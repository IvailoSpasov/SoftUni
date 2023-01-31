using Collections;

namespace CollectionsTests
{
    public class Tests
    {

        [Test]
        public void ConstructorShouldSetCorrectInitialCapacity()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            int expectedCapacity = 16;

            Assert.That(collection.Capacity, Is.EqualTo(expectedCapacity));
        }

        [Test]
        public void CountFieldWorkProperly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            int expectedCount = 4;

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void AddMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            collection.Add(1);
            int expectedItem = 1;

            Assert.That(collection[4], Is.EqualTo(expectedItem));
        }

        [Test]
        public void AddRangeMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>();

            collection.AddRange(1, 2, 3, 4);
            int[] expectedItems = new int[] { 1, 2, 3, 4 };

            for (int i = 0; i < collection.Count; i++)
            {
                Assert.That(collection[i], Is.EqualTo(expectedItems[i]));
            }
        }

        [Test]
        public void EnsureCapacityMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);

            collection.Add(17);
            int expectedCapacity = 32;
            

            Assert.AreEqual(expectedCapacity, collection.Capacity);
        }

        [Test]
        public void CollectionShouldWorkProperlyWhenAddItemOnIndex()
        {
            Collection<int> collection = new Collection<int>(1, 2);

            collection[1] = 50;
            int expectedNum = 50;


            Assert.AreEqual(collection[1], expectedNum);
        }

        [Test]
        public void CollectionShouldThrowsExceptionWhenAddItemOnInvalidIndex()
        {
            Collection<int> collection = new Collection<int>(1, 2);

            Assert.Throws<ArgumentOutOfRangeException>(() => collection[16] = 1);
        }

        [Test]
        public void InsertAtMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            collection.InsertAt(0, 384);
            int expectedNum = 384;


            Assert.AreEqual(expectedNum, collection[0]);
        }

        [Test]
        public void ExchangeMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            collection.Exchange(0, 3);
            int expectedNum0 = 4;
            int expectedNum3 = 1;


            Assert.AreEqual(expectedNum0, collection[0]);
            Assert.AreEqual(expectedNum3, collection[3]);
        }

        [Test]
        public void RemoveAtMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            int returnedNum = collection.RemoveAt(0);
            int expectedNum = 1;


            Assert.AreEqual(expectedNum, returnedNum);
        }

        [Test]
        public void ClearMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            collection.Clear();
            int expectedCount = 0;


            Assert.AreEqual(expectedCount, collection.Count);
        }

        [Test]
        public void ToStringMethodShouldWorkCorrectly()
        {
            Collection<int> collection = new Collection<int>(1, 2, 3, 4);

            string expected = "[1, 2, 3, 4]";


            Assert.AreEqual(expected, collection.ToString());
        }
    }
}