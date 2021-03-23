namespace geometry_proj
{
    public class Segment
    {
        public struct segment {
            Point A,B;
        }
        static random rnd = new random();
        public Segment( )
        {
            Point A = new Point(rnd.Next(0,200),rnd.Next(0,200));
            Point B = new Point(rnd.Next(0,200),rnd.Next(0,200));
            segment s = new segment(A,B);
        }
        /*
        stuff
        */
    }
}