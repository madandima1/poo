using System;
namespace numere_complexe
{
    public static class Operator
    {
        
        public static void adunare(Complex number1, Complex number2)
        {
            Complex result = new Complex();
            result.parte_reala=number1.parte_reala+number2.parte_reala;
            result.parte_imaginara=number1.parte_imaginara+number2.parte_imaginara;
            _print(result);
        }
        public static void scadere(Complex number1, Complex number2)
        {
            Complex result = new Complex();
            result.parte_reala=number1.parte_reala-number2.parte_reala;
            result.parte_imaginara=number1.parte_imaginara-number2.parte_imaginara;
            _print(result);
        }
        private static void _print(Complex x)
        {
            if(x.parte_imaginara>0)
            System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}i");
            else System.Console.WriteLine($"{x.parte_reala}{x.parte_imaginara}i");
            if(x.parte_imaginara==0)
            System.Console.WriteLine(x.parte_reala);
            if(x.parte_reala==0)
            System.Console.WriteLine(x.parte_imaginara+"i");
        }
         private static void _print(Complex x,int powerOfI)
        {
            switch (powerOfI)
            {
                case 2:
                {
                    if(x.parte_imaginara>0)
                    System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}");
                    else System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}i");
                    if(x.parte_imaginara==0)
                    System.Console.WriteLine(x.parte_reala);
                    if(x.parte_reala==0)
                    System.Console.WriteLine(x.parte_imaginara);
                    break;
                }
                case 4:
                {
                    if(x.parte_imaginara>0)
                    System.Console.WriteLine($"{x.parte_reala}-{x.parte_imaginara}");
                    else System.Console.WriteLine($"{x.parte_reala}+{x.parte_imaginara}i");
                    if(x.parte_imaginara==0)
                    System.Console.WriteLine(x.parte_reala);
                    if(x.parte_reala==0)
                    System.Console.WriteLine(x.parte_imaginara);
                    break;
                }

            }
        }
        public static void imultire(Complex number1, Complex number2)
        {
            Complex result = new Complex();
            result.parte_reala = number1.parte_reala*number2.parte_reala-number1.parte_imaginara*number2.parte_imaginara;
            result.parte_imaginara=number1.parte_reala*number2.parte_imaginara-number2.parte_reala*number1.parte_imaginara;
            result.parte_imaginara=Math.Abs(result.parte_imaginara);
            _print(result);
        }
        private static Complex _imultire(Complex number1, Complex number2)
        {
            Complex result = new Complex();
            result.parte_reala = number1.parte_reala*number2.parte_reala-number1.parte_imaginara*number2.parte_imaginara;
            result.parte_imaginara=number1.parte_reala*number2.parte_imaginara-number2.parte_reala*number1.parte_imaginara;
            result.parte_imaginara=Math.Abs(result.parte_imaginara);
            return result;
            //e la fel ca cea de sus doar e fara print ma gandeam la overload dar o sa fie acesibila din exterior si am ajuns la asta
            // utila la ridicarea la putere
        }
        public static void putere(Complex number , int power)
        {
            Complex result = new Complex();
            if(power == 0)
            {
                System.Console.WriteLine(1);
                return;
            }
            if(power == 1)
            {
                _print(number);
                return;
            }
            for(int i=1;i<power;i++)
            {
                result=_imultire(number,number);
            }
            if(power%4==0)
            _print(result,4);
            else if(power%2==0)
            _print(result,2);
            else _print(result);  
        }
    }
}