using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            

         const int Size = 10;
            string[] buf = new string[Size] {"АБВГДЕЖЗИК",
                                             "АБВГДЕЖЗИК",
                                             "АБВГДЕЖЗИК",
                                             "АБВГДЕЖЗИК",
                                             "КЛМНОПРСТУ",
                                             "КЛМНОПРСТУ",
                                             "КЛМНОПРСТУ",
                                             "КЛМНОПРСТУ",
                                             "КЛМНОПРСТУ",
                                             "КЛМНОПРСТУ",};
            int[,] grid = new int[Size, Size]{{1, 1, 0, 1, 1, 1, 0, 1, 1, 0},
                                              {0, 1, 1, 1, 0, 1, 1, 1, 1, 1},
                                              {1, 1, 0, 1, 1, 0, 1, 1, 1, 1},
                                              {1, 0, 1, 1, 1, 1, 1, 1, 0, 1},
                                              {0, 1, 1, 0, 1, 1, 0, 1, 1, 0},
                                              {1, 1, 0, 1, 1, 0, 1, 1, 1, 1},
                                              {1, 1, 1, 0, 1, 1, 1, 0, 1, 1},
                                              {1, 0, 1, 1, 1, 1, 0, 1, 0, 1},
                                              {0, 1, 1, 1, 0, 1, 1, 1, 0, 1},
                                              {1, 1, 0, 1, 1, 1, 0, 1, 1, 1}};
            Console.WriteLine("Ваша символьная матрица");
            // вывод зашифрованного сообщения
            for (int i = 0; i < buf.GetLength(0); i++)
            {
                
                Console.Write(buf[i].ToString()+ " ");
                Console.WriteLine();
            }
            Console.WriteLine("");

            Console.WriteLine("Ваша числовая матрица");
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                    Console.Write(grid[i, j].ToString() + " ");
                Console.WriteLine();
            }
            Console.WriteLine("");

            // поворот решетки на 90 градусов по часовой стрелке
            Console.WriteLine("90:");
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (grid[Size - j - 1, i] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.WriteLine("");
            // поворот решетки на 180 градусов по часовой стрелке
            Console.WriteLine("180:");
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (grid[Size - i - 1, Size - j - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
          
            Console.WriteLine("");
            Console.WriteLine("\nСимвольная матрица после нанесения на числовую решетку (Зашифрованная)");
            int[,] Matrix = new int[Size,Size];
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Size; j++)
                    if (grid[i, j] == 1)
                    {
                        Matrix[i, j] = Convert.ToInt32(buf[i][j]);
                        Console.Write(buf[i][j]);
                    }
                    else
                    {
                        Console.Write("-");
                    }

            }
            Console.WriteLine("");
            Console.WriteLine("\nДешифрованная");
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (grid[j, Size - i - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.ReadKey();



        }
    }
}
