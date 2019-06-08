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
            string[] buf = new string[Size] {"guhoehtyru",
                                             "llxoeretsy",
                                             "bnce.trhuz",
                                             "utp!wjyrst",
                                             "nqwmpjgtsr",
                                             "guhoehtyru",
                                             "llxoeretsy",
                                             "bnce.trhuz",
                                             "utp!wjyrst",
                                             "nqwmpjgtsr",};
            int[,] grid = new int[Size, Size]{{0, 0, 1, 0, 1, 0, 1, 0, 0, 1},
                                              {1, 1, 0, 1, 0, 1, 0, 0, 1, 1},
                                              {0, 0, 0, 0, 0, 1, 0, 1, 1, 1},
                                              {0, 0, 0, 1, 0, 1, 1, 0, 0, 1},
                                              {0, 0, 0, 0, 0, 1, 1, 1, 0, 0},
                                              {0, 0, 1, 0, 1, 0, 1, 0, 0, 1},
                                              {1, 1, 0, 1, 0, 1, 0, 0, 1, 1},
                                              {0, 0, 0, 0, 0, 1, 0, 1, 1, 1},
                                              {0, 0, 0, 1, 0, 1, 1, 0, 0, 1},
                                              {0, 0, 0, 0, 0, 1, 1, 1, 0, 0}};
            // вывод зашифрованного сообщения
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(buf[i]);
            }
            Console.WriteLine("");

            // прямой обход решетки
            Console.WriteLine("0:");
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[i][j]);
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
            // поворот решетки на 270 градусов по часовой стрелке
            Console.WriteLine("270:");
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    if (grid[j, Size - i - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                    }
            Console.WriteLine("");
            Console.ReadKey();



        }
    }
}
