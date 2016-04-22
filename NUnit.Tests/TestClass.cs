using NUnit.Framework;

namespace NUnit.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            var actual = new Class1<int>(new[] {1, 2, 3, 4, 5});
            var expected = new Class2<int>(new[] {5, 4, 3, 2, 1});

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}