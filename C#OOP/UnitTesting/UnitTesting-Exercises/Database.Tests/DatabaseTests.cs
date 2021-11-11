using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private int[] fullDatabase;
        private int minValue = 1;
        private int maxValue = 17;
        private int element = 5;
        private Database database;

        [SetUp]
        public void Setup()
        {
            fullDatabase = Enumerable.Range(minValue, maxValue).ToArray();
        }

        [Test]
        public void TestLenght()
        {
            Assert.That(() => new Database(fullDatabase), Throws.InvalidOperationException);
        }

        [Test]
        public void TestAddElement()
        {
            Assert.That(() => new Database(fullDatabase).Add(element), Throws.InvalidOperationException);
        }

        [Test]
        public void TestEmpyDatabase()
        {
            database = new Database();

            Assert.That(() => database.Remove(), Throws.InvalidOperationException);

        }

        [Test]
        public void TestRemoveFromDatabase()
        {
            int result = database.Count - 1;

            database.Remove();

            Assert.AreEqual(database.Count, result);
        }

        [Test]
        public void TestIfFenchReturnArray()
        {
            database = new Database(minValue);

            int[] test = new int[minValue];

            for (int i = 0; i < database.Count; i++)
            {
                test[i] = minValue;
            }
            int[] result = database.Fetch();

            Assert.AreEqual(test, result);
        }
    }
}