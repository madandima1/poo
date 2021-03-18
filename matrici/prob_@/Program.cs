using System;

namespace prob__
{
    class Program
    {
        static void Main(string[] args)
        {
           int n=4;int k=1;
          int [,] a=new int [n, n];
          for(int j=0;j<n;j++)
            {
                 for(int i=0;i<n;i++)
                    {
                       if(i+j<=n+1)a[i,j]=k;
                    }
                    k++;
            }
            for(int i=0;i<n;i++)
           { for(int j=0;j<n;j++)
            {
                System.Console.Write(a[i,j]+" ");
            }
            System.Console.WriteLine();
           }

        }
    }
}
