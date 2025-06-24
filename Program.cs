using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк первой матрицы: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов первой матрицы: ");
            int cols1 = Convert.ToInt32(Console.ReadLine());

            MyMatrix matrix1 = new MyMatrix(rows1, cols1);
            int i, j;
            for (i = 0; i < rows1; i++)
            {
                for (j = 0; j < cols1; j++)
                {
                    Console.Write("Введите элемент [" + i + "," + j + "]: ");
                    matrix1.SetElement(i, j, Convert.ToDouble(Console.ReadLine()));
                }
            }

            Console.Write("Введите количество строк второй матрицы: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов второй матрицы: ");
            int cols2 = Convert.ToInt32(Console.ReadLine());

            MyMatrix matrix2 = new MyMatrix(rows2, cols2);
            for (i = 0; i < rows2; i++)
            {
                for (j = 0; j < cols2; j++)
                {
                    Console.Write("Введите элемент [" + i + "," + j + "]: ");
                    matrix2.SetElement(i, j, Convert.ToDouble(Console.ReadLine()));
                }
            }

            Console.WriteLine("\nПервая матрица:");
            matrix1.Print();
            Console.WriteLine("\nВторая матрица:");
            matrix2.Print();

            MyMatrix sum = matrix1.Add(matrix2);
            if (sum != null)
            {
                Console.WriteLine("\nСумма матриц:");
                sum.Print();
            }

            MyMatrix diff = matrix1.Subtract(matrix2);
            if (diff != null)
            {
                Console.WriteLine("\nРазность матриц:");
                diff.Print();
            }

            MyMatrix product = matrix1.Multiply(matrix2);
            if (product != null)
            {
                Console.WriteLine("\nПроизведение матриц:");
                product.Print();
            }
        }
    }
}
