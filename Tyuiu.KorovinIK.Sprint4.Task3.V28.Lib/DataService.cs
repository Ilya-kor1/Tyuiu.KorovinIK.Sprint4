using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorovinIK.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 3];


                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i,3] < min)
                    {
                        min = array[i,3];
                    }
                }
            
            return min;


        }
    }
}
