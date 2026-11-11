using Tyuiu.KorovinIK.Sprint4.Task7.V27.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task7.V27.Tets
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildCalc()
        {
            
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "583197256891";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);

        }
    }
}
