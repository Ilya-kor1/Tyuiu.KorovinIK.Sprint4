using Tyuiu.KorovinIK.Sprint4.Task4.V1.Lib;
namespace Tyuiu.KorovinIK.Sprint4.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("****************************************************************************");

            Console.WriteLine("* Спринт #4                                                               *");

            Console.WriteLine("* :  Двумерные массивы. (ввод с клавиатуры)                  *");

            Console.WriteLine("* Задание #4                                                     *");

            Console.WriteLine("* Вариант #1                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");


            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());



            int[,] matrix = new int[rows, colums];




            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива:");


                    int value = Convert.ToInt32(Console.ReadLine());

                    while (value < 1 || value > 9)
                    {
                        Console.WriteLine("Ошибка! Введите число от 1 до 9:");
                        value = Convert.ToInt32(Console.ReadLine());
                    }

                    matrix[i, j] = value;
                }
            }

            Console.WriteLine("\nМассива");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            

        


                    Console.WriteLine("*****************************************************************************");

                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

                    Console.WriteLine("*****************************************************************************");

                    int res = ds.Calculate(matrix);

                    Console.WriteLine("Сумма четных элементов в матрице = " + res);
                    Console.ReadKey();
                }
            }
        }
    






