using System.Linq;
namespace time_proj
{
    public class Time
    {
        private uint ore;
        private uint minute;
        private uint secunde;
        private uint sutimi;

        public Time(uint ore, uint minute, uint secunde, uint sutimi)
        {
            this.ore = ore;
            this.minute = minute;
            this.secunde = secunde;
            this.sutimi = sutimi;
        }
           
        public Time(uint ore, uint minute, uint secunde)
        {
            this.ore = ore;
            this.minute = minute;
            this.secunde = secunde;
        }
        public Time(uint ore, uint minute)
        {
            this.ore = ore;
            this.minute = minute;
            
        }
        public Time(string time)
        {
            string[] temp = new string[4];
            temp = time.Split(":");
            this.ore = uint.Parse(temp[0]);
            this.minute = uint.Parse(temp[1]);
            this.secunde = uint.Parse(temp[2]);
            this.sutimi = uint.Parse(temp[3]);
        }
        public Time(){ }
        private void transfer(Time transformed_date)
        {
            if (transformed_date.minute < 0)
            {
                transformed_date.ore--;
                transformed_date.minute += 60;
            }
            else if (transformed_date.minute > 60)
            {
                transformed_date.ore++;
                transformed_date.minute -= 60;
            }
            if (transformed_date.secunde < 0)
            {
                transformed_date.minute--;
                transformed_date.secunde += 60;
            }
            else if (transformed_date.secunde > 60)
            {
                transformed_date.minute--;
                transformed_date.secunde += 60;
            }
            if (transformed_date.sutimi < 0)
            {
                transformed_date.secunde--;
                transformed_date.sutimi += 100;
            }
            else if (transformed_date.sutimi > 100)
            {
                transformed_date.secunde++;
                transformed_date.sutimi -= 100;
            }
        }

        public Time scadere(Time a, Time b)
        {
            Time result = new Time();
            result.ore = a.ore - b.ore;
            if (result.ore < 0)
                result.minute = a.minute - b.minute;
            if (result.minute < 0)
                result.secunde = a.secunde - b.secunde;
            result.sutimi = a.sutimi - b.sutimi;
            transfer(result);
            return result;
        }
        public Time adunare(Time a, Time b)
        {
            Time result = new Time();
            result.ore = a.ore + b.ore;
            result.minute = a.minute + b.minute;
            result.secunde = a.secunde + b.secunde;
            result.sutimi = a.sutimi + b.sutimi;
            transfer(result);
            return result;
        }
        public bool logic_operators(string semnul_logic, Time a, Time b)
        {
            bool result = false;
            switch (semnul_logic)
            {
                case "=":
                    {
                        if (a.ore == b.ore)
                            if (a.minute == b.minute)
                                if (a.secunde == b.secunde)
                                    if (a.sutimi == b.sutimi)
                                        result = true;
                                    else result = false;
                        break;
                    }
                case ">":
                    {
                        if (a.ore > b.ore)
                            result = true;
                        else if (a.ore == b.ore && a.minute > b.minute) result = true;
                        else if (a.minute == b.minute && a.secunde > b.secunde) result = true;
                        else if (a.secunde == b.secunde && a.sutimi > b.sutimi) result = true;
                        else result = false;
                        break;
                    }
                case "<" :
                    {
                        if (a.ore < b.ore)
                        result = true;
                        else if (a.ore == b.ore && a.minute < b.minute)result = true;
                        else if (a.minute == b.minute && a.secunde < b.secunde) result = true;
                        else if (a.secunde == b.secunde && a.sutimi < b.sutimi) result = true;
                        else result = false;
                        break;
                    }
                case "!=" :
                {   
                    if(a.ore!=b.ore)
                    result = true;
                    if(a.minute!=b.minute)
                    result = true;
                    if(a.secunde!=b.secunde)
                    result = true;
                    break;
                }
            
            }
            return result;
        }
        public void print()
        {
            System.Console.WriteLine($"Ore : {ore}");
            System.Console.WriteLine($"Minute : {minute}");
            System.Console.WriteLine($"Sucunde : {secunde}");
            System.Console.WriteLine($"Sutimi : {sutimi}");
        }

    }
}