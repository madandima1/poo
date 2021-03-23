using System;


namespace time_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Time a= new Time (1,10,10,90);
            System.Console.WriteLine();
            Time b= new Time("0:10:20:30");
            b.print();
            Time result = new Time();
            result.scadere(a,b);
            result.print();
            System.Console.WriteLine();
            result.adunare(a,b);
            result.print();
        }
    }
}
