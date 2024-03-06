
// track 
namespace SquareApp
{
    public class Line
    {
        public Point A { get ; set;} // x1 y1 
        public Point B { get; set;}  // x2 y2 

        public Line (Point a , Point b)
        {
            A=a ; B=b;
        }

        //длина  линии 
        public double Leght ()
        {
            // d = sqrt((x2 — x1)^2 + (y2 — y1)^2)
            return   Math.Sqrt( Math.Pow( B.X - A.X , 2) + Math.Pow (B.Y - A.Y , 2));
        }
    }
}
