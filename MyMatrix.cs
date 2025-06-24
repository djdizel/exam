using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class MyMatrix
    {
        private double[,] data;
        private int rows;
        private int cols;

        public MyMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new double[rows, cols];
        }

        public void SetElement(int row, int col, double value)
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                data[row, col] = value;
            }
        }

        public MyMatrix Add(MyMatrix other)
        {
            if (rows != other.rows || cols != other.cols)
            {
                Console.WriteLine("Ошибка: матрицы должны иметь одинаковые размеры!");
                return null;
            }

            MyMatrix result = new MyMatrix(rows, cols);
            int i, j;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    result.data[i, j] = data[i, j] + other.data[i, j];
                }
            }
            return result;
        }

        public MyMatrix Subtract(MyMatrix other)
        {
            if (rows != other.rows || cols != other.cols)
            {
                Console.WriteLine("Ошибка: матрицы должны иметь одинаковые размеры!");
                return null;
            }

            MyMatrix result = new MyMatrix(rows, cols);
            int i, j;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    result.data[i, j] = data[i, j] - other.data[i, j];
                }
            }
            return result;
        }

        public MyMatrix Multiply(MyMatrix other)
        {
            if (cols != other.rows)
            {
                Console.WriteLine("Ошибка: количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
                return null;
            }

            MyMatrix result = new MyMatrix(rows, other.cols);
            int i, j, k;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < other.cols; j++)
                {
                    result.data[i, j] = 0;
                    for (k = 0; k < cols; k++)
                    {
                        result.data[i, j] += data[i, k] * other.data[k, j];
                    }
                }
            }
            return result;
        }

        public void Print()
        {
            int i, j;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(String.Format("{0:F2}", data[i, j]) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
