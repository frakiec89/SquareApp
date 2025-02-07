// nocopy
namespace SquareApp
{
    public class Line
    {
        public Point A { get ; set;} // x1 y1 
        public Point B { get; set;}  // x2 y2 

        public Line (Point a , Point b)
        {
            if(a.Equals(b) == true)
            {
                throw new Exception("линия не может начинаться в одной точке");
            }
            A=a ; B=b;
        }

        //длина  линии 
        public double Leght ()
        {
            // d = sqrt((x2 — x1)^2 + (y2 — y1)^2)
            return   Math.Sqrt( Math.Pow( A.X , 2) + Math.Pow (B.Y - A.Y , 2));
        }

        /// <summary>
        /// точка на  линии
        /// </summary>
        /// <param name="point"></param>
        /// <returns>да если лежит</returns>
        public bool PointOnLine (Point point)
        {
            Line lineApoint  = new Line (A,point);
            Line lineBpoint  = new Line (B,point);

            if ( lineApoint.Leght() + lineBpoint.Leght() == Leght())
                return true;
            else 
                return false;
        }
    }
}
