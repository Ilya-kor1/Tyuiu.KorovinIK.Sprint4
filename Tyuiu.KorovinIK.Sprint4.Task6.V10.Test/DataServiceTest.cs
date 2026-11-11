using Tyuiu.KorovinIK.Sprint4.Task6.V10.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildCalc()
        {
            DataService ds = new DataService();
            var array = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Театр", "Кино", "Музей", "Парк" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
