
// track 
using SquareApp;

Random random = new Random(); 

int  x00 = random.Next(-10,10);
int  y00 = random.Next(-10, 10);
int  a = random.Next(4, 8);

Square square = new Square(a, new Point(x00, y00));


Console.WriteLine( $"___Создадим квадрат в  точке [{x00}.{y00}] размером  в  {a} __info____");
Console.WriteLine(square.Info());


int moveX   =random.Next(-3, 3);
int moveY =random.Next(-3, 3);


Console.WriteLine($"___ переместим  вдоль x на {moveX}"); ;
Console.WriteLine($"___ переместим  вдоль y на {moveY}"); ;
Console.WriteLine(square.Info());


double spin = random.Next(-90 , 90);

Console.WriteLine($"_____Повернем на  {spin} градусов____");
square.Spin(spin);

Console.WriteLine("___Итоговый  результат ");
Console.WriteLine(square.Info());


