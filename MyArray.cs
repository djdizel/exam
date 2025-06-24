using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class MyArray
    {
        private int[] array;

        public MyArray(int size)
        {
            array = new int[size];
        }

        public void SetElement(int index, int value)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
        }

        public void Sort()
        {
            int i, j;
            for (i = 0; i < array.Length - 1; i++)
            {
                for (j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public int FindMax()
        {
            int max = array[0];
            int i;
            for (i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int FindMin()
        {
            int min = array[0];
            int i;
            for (i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public double FindAverage()
        {
            double sum = 0;
            int i;
            for (i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public void Print()
        {
            int i;
            for (i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
