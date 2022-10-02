using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _29092022SolutionArrays
{
    public class ArraySwapRows
    {
        Random random = new Random();
        private int sizeM = 0;
        private int sizeN = 0;
        public int[,] arr;
        public ArraySwapRows(int m, int n)
        {
            sizeM = m;
            sizeN = n;
            arr = new int[sizeM, sizeN];
            FillArrayRandom();
        }


        private void FillArrayRandom()
        {
            for (int i = 0; i < sizeM; i++)
            {
                for (int j = 0; j < sizeN; j++)
                {
                    arr[i, j] = random.Next(1, 5);
                }
            }
        }
        public void ShowArray()
        {
            for (int i = 0; i < sizeM; i++)
            {
                for (int j = 0; j < sizeN; j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }

        public void SwapRows(int[,] arr, int n, int m)
        {
            int firstRow = n >= sizeM || n < 0 ? throw new Exception() : n;
            int secondRow = m >= sizeM || m < 0 ? throw new Exception() : m;

            int counter = 0;
            for (int i = 0; i < sizeM; i++)
            {
                counter = arr[firstRow, i];
                arr[firstRow, i] = arr[secondRow, i];
                arr[secondRow, i] = counter;
            }
        }
        public void SwapColumns(int[,] arr, int n, int m)
        {
            int firstColumn = n >= sizeM || n < 0 ? throw new Exception() : n;
            int secondColumn = m >= sizeM || m < 0 ? throw new Exception() : m;

            int counter = 0;
            for (int i = 0; i < sizeM; i++)
            {
                counter = arr[i, firstColumn];
                arr[i, firstColumn] = arr[i, secondColumn];
                arr[i, secondColumn] = counter;
            }
        }
    }
}
