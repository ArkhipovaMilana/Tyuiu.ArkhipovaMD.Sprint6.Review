using System.Data;

namespace Tyuiu.ArkhipovaMD.Sprint6.Review.Lib
{
    public class DataService
    {
        public int[,] GenerateMatrix(int n, int m,int n1,int n2)
        {
            int[,] array = new int[n,m];
            Random r = new Random();
            for (int i = 0; i < n;i++)
            {
                for (int j = 0; j < m;j++)
                {
                    if (j <3)
                    {
                        array[i, j] = r.Next(n1, n2);
                    }
                    else
                    {
                        array[i, j] = array[i, j - 1] + array[i, j - 2] + array[i,j-3];
                    }
                }
            }
            return array;
        }
        public int GetMatrix(int[,] array, int n1,int n2,int r,int k,int l)
        {
            bool cond1 = n1 < n2;
            bool cond2 = k<l;
            bool cond3 = r<=array.GetLength(0);
            bool cond4 = (l - k) <= array.GetLength(1);
            if (cond1&&cond2&&cond3&&cond4)
            {
                int ResultSum = 0;
                for (int j = k; j <= l; j++)
                {
                    if (j % 2 != 0)
                    {
                        ResultSum += array[r-1, j];
                    }
                }
                return ResultSum;
            }
            else
            {
                throw new Exception("Данные некорректны");
            }
        }
    }
}
