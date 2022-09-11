using System;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("vvedite poryadok:");
                int porydok = Convert.ToInt32(Console.ReadLine());
                MyMatrix instance = new MyMatrix();
                int[,] matrix = instance.MatrixCreate(porydok);
            while (porydok != 0)
            {
                Console.WriteLine("////////");
                Console.WriteLine("vvedite poryadok:(0 to exit)");
                 porydok = Convert.ToInt32(Console.ReadLine());
                instance.NextMatrix(matrix, porydok);
            }
        }
        class MyMatrix
        {
            Random random = new Random();
            public MyMatrix()
            {

            }
            public int[,] MatrixCreate(int x)
            {
                int[,] matrix = new int[x, x];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(0, 10);
                        Console.Write("{0}\t", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                return matrix;
            }
            public int[,] NextMatrix(int[,] matrix, int x)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write("{0}\t", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                return matrix;
            }
        }
    }
}
