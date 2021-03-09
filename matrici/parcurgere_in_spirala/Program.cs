using System;

namespace prob_1
{
    class Program
    {
        // conditii speciale pentru n par si m impar sau invers
        //centrul
        static void Main(string[] args)
        {
          int n=4;int k=1;
          int [,] a=new int [n, n];
          for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                    {
                        a[i,j]=k;
                        k++;
                        if(k==10)k=1;
                        System.Console.Write(a[i,j]+ " ");
                    }
            System.Console.WriteLine();
            }
            k = 0;
            while (k < n)
            {
                for (int i = k; i < n; i++)// sus
                System.Console.Write(a[k,i]+" ");
                for (int i = k+1; i < n; i++)//dreapta
                System.Console.Write(a[i,n-1]+" ");
                for (int i = n-2; i > k; i--)   //jos
                System.Console.Write(a[n-1,i]+" ");
                for (int i = n-1; i > k; i--)   //stanga
                System.Console.Write(a[i,k]+" ");
                k++;
                n--;
            }
            if(n==k)
            System.Console.Write(a[n-1,n-1]);

        }
    }
}
