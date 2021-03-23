using System;
namespace numere_complexe
{
    public class Complex
    {
        public int parte_reala;
        public int parte_imaginara;
        public Complex(){}
        public Complex(int parte_reala,int parte_imaginara)
        {
            this.parte_reala = parte_reala;
            this.parte_imaginara = parte_imaginara;
        }
        public Complex(int parte_reala)
        {
            this.parte_reala = parte_reala;
            parte_imaginara = 0;
        }
        public void print()
        {
            if(parte_imaginara>0)
            System.Console.WriteLine($"{parte_reala}+{parte_imaginara}i");
            else System.Console.WriteLine($"{parte_reala}{parte_imaginara}i");
            if(parte_imaginara==0)
            System.Console.WriteLine(parte_reala);
            if(parte_reala==0)
            System.Console.WriteLine(parte_imaginara+"i");
        }
        public void forma_trigonometrica()
        {
            float r; float teta;
            r=(float)Math.Sqrt(parte_reala*parte_reala+parte_imaginara*parte_imaginara);
            teta=(float)Math.Atan(parte_imaginara/parte_reala);
            System.Console.WriteLine($"forma trigonometrica : {r}(cos {teta} + i sin {teta})");
        }
    }
}