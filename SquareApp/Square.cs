// nocopy
namespace SquareApp
{

    // partial - это  разделение  - тоесть  в  другом файле есть  продолжение  класса 
    // я это  сделал  что бы  вы могли часть  класса скопировать  а  часть  нет 
    public partial class Square 
    {
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }
        public Point D { get; private set; }


        /// <summary>
        /// квадрат на  осо xy в точке  A = 00
        /// </summary>
        /// <param name="a"></param>
        public Square(double a)
        {
            // если  a = 5 
            A = new Point(0, 0); // 00 
            B = new Point(0, a); // 05
            C = new Point(a, a); // 55 
            D = new Point(a, 0); // 50
        }


        /// <summary>
        /// startPoint нижней  левый угол квадрата  стороны  которого паралельны оси Ox или  Oy
        /// </summary>
        /// <param name="a"></param>
        /// <param name="startPoint"></param>
        public Square(double a, Point startPoint) : this(a)
        {
            MoveX(startPoint.X);
            MoveY(startPoint.Y);
        }


        public Square(Point a, Point b, Point c, Point d)
        {
            if (IsSquare(a, b, c, d) == true)
            {
                A = a; B = b; C = c; D = d;
            }
            else { A = new Point(0, 0); B = new Point(0, 0); C = new Point(0, 0); D = new Point(0, 0); }
        }


        /// <summary>
        /// проверяет  верный  ли  квадрат
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private bool IsSquare(Point a, Point b, Point c, Point d)
        {
            Line line1 = new Line(a, b);
            Line line2 = new Line(b, c);
            Line line3 = new Line(c, d);
            Line line4 = new Line(d, a);
            Line linetR = new Line(a, c);
            Line linetR2 = new Line(b, d);

            double sum = line1.Leght() + line2.Leght() + line3.Leght() + line4.Leght();

            if (sum / 4 == line1.Leght() && linetR.Leght() == linetR.Leght())
                return true;
            else
                return false;
        }


        //перемещение по  игрику
        public void MoveY(double step)
        {
            A.Y += step;
            B.Y += step;
            C.Y += step;
            D.Y += step;
        }

        //перемещение по  иксу
        public void MoveX(double step)
        {
            A.X += step;
            B.X += step;
            C.X += step;
            D.X += step;
        }

        public string Info()
        {
            return $"Квадрат с координатами a:({A.X}|{A.Y}), b:({B.X}|{B.Y}), c:({C.X}|{C.Y}),D:({D.X}|{D.Y})";
        }
    }
}
