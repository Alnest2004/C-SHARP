using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Matrix mat = new Matrix(3, 3);
                Matrix mat1 = new Matrix(3, 3);
                if (mat.arr.Length != mat1.arr.Length || mat.arr.Length < 0 || mat1.arr.Length < 0)
                {
                    throw new Exception("Error");
                }
                mat.output(mat.arr);
                mat.input(mat.arr);
                Console.WriteLine("Заполнение второй матрицы рандомом");
                mat1.random(mat1.arr);
                mat1.output(mat1.arr);
                Console.WriteLine("Сложение первой и второй матриц");
                mat.summat(mat.arr, mat1.arr);
                mat.output(mat.arr);
                Console.WriteLine("Сложение матрицы и числа");
                mat1.sum(mat1.arr, 3);
                mat1.output(mat1.arr);
                Console.WriteLine("Сравнение матриц");
                mat.SravnMat(mat.arr, mat1.arr);
                Console.WriteLine("Сравнение матрицы и числа");
                mat.Sravn(mat.arr, 8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
    class Matrix
    {
        public int[,] arr;
        public int rows;
        public int cols;
        public Matrix(int rows, int cols)
        {
            this.arr = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }
        public void output(int[,] arr)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void input(int[,] arr)
        {
            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"A[{i + 1},{j + 1}]=");
                    
                    arr[i, j] = int.Parse(Console.ReadLine());
                    if (arr[i, j] < 0)
                    {
                        ++count;
                    }
                    
                }

            }
            if (count == 9)
            {
                Console.WriteLine("Все отрицательные!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void random(int[,] arr)
        {
            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = r.Next(0, 100);
                }

            }

        }
        public void summat(int[,] arr, int[,] arr1)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] += arr1[i, j];
                }

            }
        }
        public void sum(int[,] arr, int e)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    arr[i, j] += e;
                }

            }
        }
        public void SravnMat(int[,] arr, int[,] arr1)
        {
            double r;
            double r1;
            int sum = 0;
            int sum1 = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += (int)Math.Pow(arr[i, j], 2);
                    sum1 += (int)Math.Pow(arr1[i, j], 2);
                }

            }
            r = Math.Sqrt(sum);
            r1 = Math.Sqrt(sum1);
            if (r == r1) Console.WriteLine("0");
            else if (r < r1) Console.WriteLine("-1");
            else Console.WriteLine("1");
        }
        public void Sravn(int[,] arr, int e)
        {
            double r;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += (int)Math.Pow(arr[i, j], 2);

                }

            }
            r = Math.Sqrt(sum);
            if (r == e) Console.WriteLine("0");
            else if (r < e) Console.WriteLine("-1");
            else Console.WriteLine("1");

        }

    }
}