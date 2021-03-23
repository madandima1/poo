using System;

namespace numere_Rationale
{
    class Program
    {
        static void Main(string[] args)

        {
            Rational a = new Rational (1,2);
            a.print();
            Rational b = new Rational (1,3);
            b.print();
            //a.forma_ireductibila();       // simplificarea fractiei pentru operatii este implicita
            // Operator.adunare(a,b);       // utila doar pentru inceput
            // Operator.scadere(a,b);       //operator class gestioneaza toate operatiile cu numere rationale
            // Operator.impartire(a,b);     // operatiile logice returneza 1 sau 0 in functie de semnul introdus < , <= , > , >= , = , != 
            // Operator.imultire(a,b);      
            //System.Console.WriteLine(Operator.logic_operators("=", a, b));
        }
    }
}
