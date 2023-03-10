System.Console.Clear();
//System.Console.SetCursorPosition(10, 4);
//System.Console.WriteLine("+");

int xa = 40; // координата x верхнего левого угла окна
int ya = 1; // координата y верхнего левого угла окна
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

System.Console.SetCursorPosition(xa, ya); // выводим символ на экран
System.Console.WriteLine("+");
System.Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("+");
System.Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("+");

int x = xa, y = xb; // координаты первой точки
int count = 0; // счетчик количества рисований

while (count < 10000) // пока количество рисований не станет меньше 10000
{
    int what = new Random().Next(0, 3); // выбираем случайную точку на плоскости
    if (what == 0)  // левый нижний угол
    {
        x = (x + xa) / 2; // перемещаем точку в середину
        y = (y + ya) / 2; 
    }
    if (what == 1) // правый нижний угол
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2) // правый верхний угол
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    System.Console.SetCursorPosition(x, y); // выводим символ на экран
    System.Console.WriteLine("+");
    count++; // увеличиваем счетчик количества рисований
}