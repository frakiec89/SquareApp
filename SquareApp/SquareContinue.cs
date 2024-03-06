
// nocopy 
namespace SquareApp
{

    // продолжение класса  - вы можете  не разделять  -  оставить  все  в  одном  

    public partial class Square
    {
        #region Spin все для вращения

        /// <summary>
        /// вращает   фигуру  на  определенный градус против  часовой стрелки
        /// </summary>
        /// <param name="degrees"></param>
        public void Spin(double degrees)
        {
            double angle = Math.PI * degrees / 180.0; // что  то  там с радианами  
            double sinAngle = Math.Sin(angle); // пригодится 
            double cosAngle = Math.Cos(angle); // пригодиться 

            Point pointOfSpin = GetPoinСenterSquare(); // точка врашения - Центр  квадрата 

            A = GetNewPointSpin(A, pointOfSpin, sinAngle, cosAngle);
            B = GetNewPointSpin(B, pointOfSpin, sinAngle, cosAngle);
            C = GetNewPointSpin(C, pointOfSpin, sinAngle, cosAngle);
            D = GetNewPointSpin(D, pointOfSpin, sinAngle, cosAngle);
        }

        /// <summary>
        /// получаем  точку вращения квадрата  
        /// </summary>
        /// <returns></returns>
        private Point GetPoinСenterSquare()
        {
            //(x1 + x2 + x3 + x4) / 4,
            //(y1 + y2 + y3 + y4) / 4

            double x = (A.X + B.X + C.X + D.X) / 4.0;
            double y = (A.Y + B.Y + C.Y + D.Y) / 4.0;
            return new Point(x, y);// 
        }

        /// <summary>
        /// получаем новую  точку  при вращении 
        /// </summary>
        /// <param name="point">Какая  точка передит</param>
        /// <param name="pOfs"> точка вращения</param>
        /// <param name="sinAngle">синус угла</param>
        /// <param name="cosAngle">косинус угла</param>
        /// <returns></returns>
        private Point GetNewPointSpin(Point point, Point pOfs, double sinAngle, double cosAngle)
        {
            Point newPoint = new Point(0, 0); // новая  точка  = пока просто  00 

            //X' = (X - X0) * cos α - (Y - Y0) * sin α + X0
            newPoint.X = (point.X - pOfs.X) * cosAngle - (point.Y - pOfs.Y) * sinAngle + pOfs.X;

            //Y' = (X - X0) * sin α + (Y - Y0) * cos α + Y0
            newPoint.Y = (point.X - pOfs.X) * sinAngle + (point.Y - pOfs.Y) * cosAngle + pOfs.Y;

            newPoint.X = Math.Round(newPoint.X, 1); // округлим 
            newPoint.Y = Math.Round(newPoint.Y, 1);  // округлим 
            return newPoint;
        }

        #endregion
    }
}
