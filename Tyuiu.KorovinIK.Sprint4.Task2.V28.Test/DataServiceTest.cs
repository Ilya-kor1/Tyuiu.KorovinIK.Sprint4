using Tyuiu.KorovinIK.Sprint4.Task2.V28.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 3, 3, 4, 5, 6, 7, 5, 4, 9, 3, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 38;

            Assert.AreEqual(wait, res);
        }
    }
}
