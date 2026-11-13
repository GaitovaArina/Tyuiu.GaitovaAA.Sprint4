using Tyuiu.GaitovaAA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.GaitovaAA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -4, -3, -2, -1, 0 },
                                          { 1, 2, 3, 4, -4 },
                                          { -3, -2, -1, 0, 1 },
                                          { 2, 3, 4, -4, -3 },
                                          { -2, -1, 0, 1, 2 } };

            int res = ds.Calculate(mas2);
            int wait = 10;

            Assert.AreEqual(wait, res);
        }
    }
}
