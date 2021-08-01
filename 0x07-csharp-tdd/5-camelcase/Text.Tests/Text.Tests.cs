using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test2Words()
        {
            Assert.AreEqual(2, Text.Str.CamelCase("helloWorld"));
        }

        [Test]
        public void TestMultipleWords()
        {
            Assert.AreEqual(5, Text.Str.CamelCase("helloWorldIAmHere"));
        }

        [Test]
        public void Test1Word()
        {
            Assert.AreEqual(1, Text.Str.CamelCase("hello"));
        }

        [Test]
        public void TestEmptyString()
        {
            Assert.AreEqual(0, Text.Str.CamelCase(""));
        }
    }
}