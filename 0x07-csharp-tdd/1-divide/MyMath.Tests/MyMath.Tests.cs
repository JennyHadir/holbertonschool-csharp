using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        ///<summary>Test simple division by 2</summary>
        public void TestDivision()
        {
            int[,] matrix = new int[,] { { 2, 5 }, { 7, 4 }, { 11, 6 }, { 17, 14 } };
            int num = 2;
            int[,] NewMatrix = MyMath.Matrix.Divide(matrix, num);
            int[,] CheckMatrix = new int[,] { { 1, 2 }, { 3, 2 }, { 5, 3 }, { 8, 7 } };
            Assert.AreEqual(CheckMatrix, NewMatrix);
        }

        [Test]
        ///<summary>Test Divisions by zero</summary>
        public void TestDivisionByZero()
        {
            int[,] matrix = new int[,] { { 2, 4 }, { 8, 4 }, { 10, 6 }, { 12, 14 } };
            int num = 0;
            int[,] NewMatrix = MyMath.Matrix.Divide(matrix, num);
            Assert.AreEqual(null, NewMatrix);
        }
        [Test]
        ///<summary>Test Divisions o</summary>
        public void TestMatrixNull()
        {
            int[,] matrix = null;
            int num = 2;
            int[,] NewMatrix = MyMath.Matrix.Divide(matrix, num);
            Assert.Null(NewMatrix);
        }
    }
}