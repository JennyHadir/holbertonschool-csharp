using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void TestEmptyList()
        {
            List<int> ls = new List<int>();
            Assert.AreEqual(0, MyMath.Operations.Max(ls));
        }

        [Test]
        public void TestPositiveNegativeList()
        {
            List<int> ls = new List<int>();
            ls.Add(0);
            ls.Add(-1);
            ls.Add(-3);
            ls.Add(2);
            ls.Add(6);
            Assert.AreEqual(6, MyMath.Operations.Max(ls));
        }

        [Test]
        public void TestPositiveList()
        {
            List<int> ls = new List<int>();
            ls.Add(3);
            ls.Add(1);
            ls.Add(0);
            ls.Add(6);
            ls.Add(4);
            Assert.AreEqual(6, MyMath.Operations.Max(ls));
        }

        [Test]
        public void TestNegativeList()
        {
            List<int> ls = new List<int>();
            ls.Add(-1);
            ls.Add(-6);
            ls.Add(-2);
            ls.Add(-3);
            Assert.AreEqual(-1, MyMath.Operations.Max(ls));
        }
    }
}