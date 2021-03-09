namespace prob_1
{
    public class stars
    {   
        private int line_counter;
        
        public stars (int a)
        {
            line_counter =a;
        }
        public stars ()
        {

        }
        ~stars()
        {
            System.Console.WriteLine("Destructor was called !");
        }
        private void stars_printer(int number)
        {
            while(number!=0)
            {
                System.Console.Write("*");
                number--;
            }
        }
        public void stars_line_printer()
        {   int temp;
            int n=1;
            while(line_counter>0)
            {   temp=n;
                stars_printer(temp);
                n++;
                line_counter--;
                System.Console.WriteLine();
            }
        }
    }
}