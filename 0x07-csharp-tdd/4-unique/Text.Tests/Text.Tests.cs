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
        public void TestNoUniqueChar()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar("hellohello"));
        }

        [Test]
        public void TestEmptyString()
        {
            Assert.AreEqual(-1, Text.Str.UniqueChar(""));
        }

        [Test]
        public void TestUniqueCharInEnd()
        {
            Assert.AreEqual(10, Text.Str.UniqueChar("aabbccddeef"));
        }

        [Test]
        public void TestUniqueCharFirst()
        {
            Assert.AreEqual(0, Text.Str.UniqueChar("helloworld"));
        }

        [Test]
        public void TestUniqueCharInMiddle()
        {
            Assert.AreEqual(8, Text.Str.UniqueChar("helloholberton"));
        }
    }
}