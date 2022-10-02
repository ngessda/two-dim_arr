using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29092022SolutionArrays
{
    public class SnakeArray
    {
        private int RowsLength;
        private int ColumnsLength;
        private int[,] arr;
        public SnakeArray(int n, int m)
        {
            RowsLength = n;
            ColumnsLength = m;
            arr = new int[RowsLength, ColumnsLength];
            CreateSnake();
        }
        private void CreateSnake()
        {
            bool flag = true;
            int counter = 1;
            for (int i = 0; i < RowsLength; i++)
            {
                switch (flag)
                {
                    case true:
                        for (int j = 0; j < ColumnsLength; j++)
                        {
                            arr[i, j] = counter;
                            counter++;
                        }
                        flag = false;
                        break;
                    case false:
                        for (int j = ColumnsLength - 1; j >= 0; j--)
                        {
                            arr[i, j] = counter;
                            counter++;
                        }
                        flag = true;
                        break;
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
