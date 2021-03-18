using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;
namespace robot
{
    
    public class GiantKillerRobot
    {

        static Random rnd=new Random();
        static List<string> myTarget;
        private int specialAbility;
        private int atk=90;
        private int def=80;
        public void initialize ()
        {   
            System.Console.Write("INITIALIZING.");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            Thread.Sleep(1000);
            System.Console.Write(".");
            System.Console.WriteLine();
            System.Console.WriteLine("Robot is intialized !");
            System.Console.WriteLine("1000 HP 90 ATK 80 DEF");
            System.Console.WriteLine("SPECIAL ABILITY:");
            System.Console.WriteLine("press 1 for one punch one kill");
            System.Console.WriteLine("press 2 for infinite ammo");
            System.Console.WriteLine("press 3 for invisibility");
            int temp;
            temp =int.Parse(Console.ReadLine());
            switch (temp)
            {
                case 1:
                {
                    specialAbility =temp;
                    System.Console.WriteLine("You chose one punch one kill");
                    break;
                }
                case 2:
                {
                    specialAbility =temp;
                    System.Console.WriteLine("You chose infinite ammo");
                    break;
                }
                case 3:
                {
                    specialAbility =temp;
                    System.Console.WriteLine("You chose invisibility");
                    break;
                }
            }
            
            
        }
        private string _intensity;
       public string Intensity
        {
            get
            {
              return _intensity;  
            }
            set 
            {
                _intensity =value;
            }
        }
        private int _health=500;
        public int Health
        {
            get {return _health;}   //robot health
            set{_health=value;}
        }
         private int target_health=500;
        public int Target_Health
        {
            get {return target_health;}
            set{target_health=value;}
        }
        private static List<string> targetList;
        public List<string> Target 
        {
            set
            {
                targetList=value;
            }
            get 
            {
                return targetList;
            }
        }
        public string currentTarget()
        {
            return targetList.ElementAt(targetList.Count-1);
        }
        public string AcquireNextTarget()
        {
            targetList.RemoveAt(targetList.Count-1);
            return targetList.ElementAt(targetList.Count-1);
        }
        private void player_damage(int dmg)
        {
            Health-=dmg;
        }
        public bool Active()
        {
            if(_health != 0) return true;
            else return false;
        }
        private void target_damge(int dmg)
        {
            Target_Health-=dmg;
        }
        public bool isAlive()
        {
            if(target_health != 0) return true;
            else return false;
        }
        public void FireLaserAt(string target)
        {
            System.Console.WriteLine("looks like you've been hit");
            Target_Health-=atk;
            Health-=rnd.Next(10,300);
            System.Console.WriteLine($"Robot HP: {Health} ");
            System.Console.WriteLine($"Target HP: {Target_Health} ");
        }
        
    }
}