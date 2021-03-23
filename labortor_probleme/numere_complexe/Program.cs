using System;

namespace numere_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
           Complex a = new Complex(5,-3);
           Complex b = new Complex(1,5);
           a.print();
           b.print();
           //Operator.adunare(a,b); //exceptie forma trigonometrica este implementata in Complex
           //Operator.scadere(a,b); //operator class raspunde de operatii cu numre complexe
           a.forma_trigonometrica();

        }
    }
}
