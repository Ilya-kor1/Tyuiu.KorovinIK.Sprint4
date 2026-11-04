using Tyuiu.KorovinIK.Sprint4.Task1.V22.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("***************" +
                "**************************************************************");

            Console.WriteLine("* Спринт #4                                                               *");

            Console.WriteLine("* : Одномерные массивы (ввод с клавиатуры)               *");

            Console.WriteLine("* Задание #1                                                     *");

            Console.WriteLine("* Вариант #22                                                         *");

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
                Console.WriteLine("Введите элемент массива №" + (i + 1));

                int value = Convert.ToInt32(Console.ReadLine()); 

                while (value < 2 || value > 9)
                {
                    Console.WriteLine("Ошибка! Введите число от 2 до 9:");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                numsArray[i] = value;
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

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}