using Tyuiu.KorovinIK.Sprint4.Task7.V27.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task7.V27

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "583197256891";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #4                                                               *");

            Console.WriteLine("* :  Двумерные массивы. (ввод с клавиатуры)                  *");

            Console.WriteLine("* Задание #7                                                    *");

            Console.WriteLine("* Вариант #27                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

          int index = 0;

            Console.WriteLine("\nМассив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }






                    Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");
            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Количество четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}