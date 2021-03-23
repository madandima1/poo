namespace geometry_proj
{
    public class Point
    {
        public int X,Y;
        public Point(int X, int Y)
        {
            Point point = new Point(X,Y);// int point
        }
        public Point(float x, float y)
        {
             Point point = new Point(x,y); // float point
        }
        public void move_point(Point p,int lungime)
        {
            p.X+=lungime;
            p.Y+=lungime;
        }
    }
}