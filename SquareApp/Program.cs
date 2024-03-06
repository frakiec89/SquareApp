
// track 
using SquareApp;
Square square = new Square(5);


Console.WriteLine( "___Создадим квардрат в  точке 0_0 размером  в  5 __info____");
Console.WriteLine(square.Info());


Console.WriteLine("_____Повернем на  90 градусов____");
square.Spin(90);
Console.WriteLine(square.Info());


Console.WriteLine("_____Повернем на  - 90 градусов____");
square.Spin(- 90);
Console.WriteLine(square.Info());

Console.WriteLine("_____Повернем на  45 градусов____");
square.Spin(45);
Console.WriteLine(square.Info());