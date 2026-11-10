using Tyuiu.KorovinIK.Sprint4.Task4.V1.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
                { 2, 5, 1, 7, 5},
                { 4, 4, 7, 4, 4 },
                { 7, 1, 6, 8, 8 },
                { 8, 1, 5, 8, 4},
                { 8, 9, 1, 7, 3} };

            int rows = ds.Calculate(mas2);
            int wait = 68;

            Assert.AreEqual(wait,rows);
        }
    }
}
