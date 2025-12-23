using Tyuiu.ArkhipovaMD.Sprint6.Review.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint6.Review.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] array = { { 1,1,1,1,1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            int n1 = 1, n2 = 100, r = 3, k = 2, l = 4;

            int actual = ds.GetMatrix(array, n1, n2, r, k, l);
            int expected = 1;

            Assert.AreEqual(expected, actual);

        }

    }
}
