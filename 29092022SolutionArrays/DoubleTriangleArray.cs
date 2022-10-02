using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29092022SolutionArrays
{
    public class DoubleTriangleArray
    {
        private int RowsLength;
        private int ColumnsLength;
        private int[,] arr;
        public DoubleTriangleArray(int n, int m)
        {
            RowsLength = n;
            ColumnsLength = m;
            arr = new int[RowsLength, ColumnsLength];
            CreateDoubleTriangle();
        }
        private void CreateDoubleTriangle()
        {
            int counter = 1;
            for (int i = 0; i < RowsLength; i++)
            {
                for (int j = i; j < ColumnsLength; j++)
                {
                    arr[i, j] = counter;
                    counter++;
                }
            }
            for (int i = RowsLength - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--) 
                {
                    arr[i, j] = counter;
                    counter++;
                }
            }
        }

        public void ShowArray()
        {
            for (int i = 0; i < RowsLength; i++)
            {
                for (int j = 0; j < ColumnsLength; j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
