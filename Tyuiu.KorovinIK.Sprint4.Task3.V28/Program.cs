using Tyuiu.KorovinIK.Sprint4.Task3.V28.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KorovinIK.Sprint4.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #4                                                               *");

            Console.WriteLine("* : Двумерные массивы. (статический ввод)                   *");

            Console.WriteLine("* Задание #3                                                     *");

            Console.WriteLine("* Вариант #28                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            int[,] numsArray ={
                { 5, 4, 9, 8, 5 },
                { 4, 6, 6, 9, 9 },
                { 9, 8, 4, 8, 8 },
                { 6, 8, 6, 8, 9 },
                { 9, 4, 6, 6, 7 }
            };

            for (int i = 0; i < numsArray.GetLength(0); i++)
            {
                for (int j = 0; j < numsArray.GetLength(1); j++)
                {
                    Console.Write(numsArray[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Минимальный элемент в четвертом столбце = " + res);
            Console.ReadKey();
        }
    }
}