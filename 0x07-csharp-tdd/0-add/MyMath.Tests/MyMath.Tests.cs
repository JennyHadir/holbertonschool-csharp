using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary> Testing different cases</summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        ///<summary>Test 2 positive numbers</summary>
        public void Test2positive([Values(3)] int x, [Values(2)] int y)
        {
            int result = MyMath.Operations.Add(x, y);
            Assert.AreEqual(5, result);
        }

        [Test]
        ///<summary>Test 1 positive with 1 negative number</summary>
        public void Test1negative1positive([Values(-3)] int x, [Values(2)] int y)
        {
            int result = MyMath.Operations.Add(x, y);
            Assert.AreEqual(-1, result);
        }
        ///<summary>Test 2 negative numbers</summary>
        [Test]
        public void Test2negatives([Values(-3)] int x, [Values(-2)] int y)
        {
            int result = MyMath.Operations.Add(x, y);
            Assert.AreEqual(-5, result);
        }
    }
}