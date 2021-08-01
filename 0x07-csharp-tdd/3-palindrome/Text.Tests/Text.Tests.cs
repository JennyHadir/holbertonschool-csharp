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
            Assert.AreEqual(false, Text.Str.IsPalindrome("Holberton"));
        }

        [Test]
        public void TestPalindromeUpperCase()
        {
            string str = "Racecar";
            Assert.AreEqual(true, Text.Str.IsPalindrome(str));
        }

        [Test]
        public void TestPalindromeSpaces()
        {
            string str = "taco cat";
            Assert.AreEqual(true, Text.Str.IsPalindrome(str));
        }

        [Test]
        public void TestPalindromeSpecificChars()
        {
            string str = "A man, a plan, a canal: Panama.";
            Assert.AreEqual(true, Text.Str.IsPalindrome(str));
        }

        [Test]
        public void TestNotPalindromeSpecificChars()
        {
            string str = "Welcome! This is Holberton. ";
            Assert.AreEqual(false, Text.Str.IsPalindrome(str));
        }
    }
}