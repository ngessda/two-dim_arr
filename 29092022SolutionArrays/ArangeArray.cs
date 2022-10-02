using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _29092022SolutionArrays
{
    public class ArangeArray
    {
        private int RowsLength;
        private int ColumnsLength;
        private int[,] arr;
        public ArangeArray(int n, int m)
        {
            RowsLength = n;
            ColumnsLength = m;
            arr = new int[RowsLength, ColumnsLength];
            CreateArrange();
        }
        private void CreateArrange()
        {
            int counter = 1;
            for (int i = 0; i < RowsLength; i++)
            {
                for (int j = 0; j < ColumnsLength; j++)
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
