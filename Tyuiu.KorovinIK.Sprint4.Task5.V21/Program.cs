using Tyuiu.KorovinIK.Sprint4.Task5.V21.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task5.V21
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #4                                                               *");

            Console.WriteLine("* :  Двумерные массивы. (ввод с клавиатуры)                  *");

            Console.WriteLine("* Задание #5                                                     *");

            Console.WriteLine("* Вариант #21                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");


            Console.WriteLine("количество строк в массиве: ");
            int rows = 5;

            Console.WriteLine("количество столбцов в массиве: ");
            int colums = 5;



            int[,] matrix = new int[rows, colums];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rnd.Next(-8,3);
                }
            }

            

            Console.WriteLine("\nМассива");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }






            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            int[,] res = ds.Calculate(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{res[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
