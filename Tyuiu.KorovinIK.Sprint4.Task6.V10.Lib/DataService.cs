using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorovinIK.Sprint4.Task6.V10.Lib
{
    public class DataService : ISprint4Task6V10
    {
        

        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length < 7);
            return mas;
        }
    }
}
    