// nocopy
namespace SquareApp
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get;  set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Определяет  совпадение точек
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Да если точки равны</returns>
        public bool Equals(Point other) 
        { 
            if(other.X == X && other.Y == Y)
                return true;
            return false;
        
        }

    }
}
