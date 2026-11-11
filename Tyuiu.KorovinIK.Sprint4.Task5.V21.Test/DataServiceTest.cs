using Tyuiu.KorovinIK.Sprint4.Task5.V21.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
                { 0, -1, 1, 2, -5},
                { -4, -4, -7, -4, -4 },
                { -7, -1, -6, -8, -8 },
                { -8, -1, -5, -8, -4},
                { -8, 2, -1, -7, -3} };

            int[,] wait = new int[5, 5] {
                        { 0, -1, 1, 1, -5},
                        { -4, -4, -7, -4, -4 },
                        { -7, -1, -6, -8, -8 },
                        { -8, -1, -5, -8, -4},
                        { -8, 1, -1, -7, -3} };

            int[,] res = ds.Calculate(mas2);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }
    }
}