using System;
using System.Linq;
using System.Collections.Generic;
namespace robot
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> t=new List <string> (){"Animals", "Humans", "Superheroes"};
            GiantKillerRobot robot =new GiantKillerRobot();
            Planets earth = new Planets();
            robot.initialize();
            robot.Intensity="Kill";
            robot.Target=t;
            while(robot.Active() && earth.ContainsLife())
            {
               
            }
            System.Console.WriteLine(robot.currentTarget());
            System.Console.WriteLine(robot.AcquireNextTarget());
            
        }
    }
}
