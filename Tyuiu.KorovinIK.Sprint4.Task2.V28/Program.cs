using Tyuiu.KorovinIK.Sprint4.Task2.V28.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd  = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #4                                                               *");

            Console.WriteLine("* : Одномерные массивы. (генератор случайных чисел)               *");

            Console.WriteLine("* Задание #2                                                     *");

            Console.WriteLine("* Вариант #28                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            int len = 12;
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {

                numsArray[i] = rnd.Next(2,10);
            }

            Console.WriteLine();
            Console.WriteLine("Массив:");

            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }



            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Cумма не четных элементов = " +res);
            Console.ReadKey();
        }
    }
}