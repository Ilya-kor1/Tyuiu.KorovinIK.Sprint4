using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorovinIK.Sprint4.Task2.V28.Lib
{
    public class DataService : ISprint4Task2V28
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
