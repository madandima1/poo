using System;
namespace geometry_proj
{
    public class Segment
    {
       public Point A,B;
        static Random rnd = new Random();
        public Segment( )
        {
            A.X = rnd.Next(0,200);
            A.Y = rnd.Next(0,200);
            B.X = rnd.Next(0,200);
            B.Y = rnd.Next(0,200);
        }
        /*
        stuff
        */
    }
}