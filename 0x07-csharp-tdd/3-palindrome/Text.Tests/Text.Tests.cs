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
        public void TestEmptyString()
        {
            string str = "";
            Assert.AreEqual(true, Text.Str.IsPalindrome(str));
        }

        [Test]
        public void TestPalindrome()
        {
            string str = "level";
            Assert.AreEqual(true, Text.Str.IsPalindrome(str));
        }

        [Test]
        public void TestNotPalindrome()
        {
            Assert.AreEqual(false, Text.Str.IsPalindrome("visual"));
        }
    }
}