namespace numere_Rationale
{

    public class Rational
    {
        public int numitor;
        public int numarator;

        public Rational (int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
        }
        public Rational(){}
        public Rational(int numarator)
        {
            this.numarator = numarator;
            this.numitor = 1;
        }
        public void print()
        {
            System.Console.Write($"{numarator}/{numitor}");
            System.Console.WriteLine();
        }
        public void forma_ireductibila()
        {
            int tmp = Operator.cmmc(numarator,numitor);
            numarator /= tmp;
            numitor /= tmp;
        }
    }
}