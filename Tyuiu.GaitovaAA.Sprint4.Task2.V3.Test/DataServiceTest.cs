using Tyuiu.GaitovaAA.Sprint4.Task2.V3.Lib;

namespace Tyuiu.GaitovaAA.Sprint4.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 24;

            Assert.AreEqual(wait, res);
        }
    }
}
