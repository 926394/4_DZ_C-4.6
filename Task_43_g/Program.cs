// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("1 уравнение");
Console.Write("Введите значение b1 = ");
double b01 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1 = ");
double k1x = double.Parse(Console.ReadLine()!);
Console.WriteLine("2 уравнение");
Console.Write("Введите значение b2 = ");
double b02 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2 = ");
double k2x = double.Parse(Console.ReadLine()!);


double sumX(double b01, double k1x, double b02, double k2x)
{      
    double u0 = k1x - k2x;
    double u1 = b02 - b01;
    return u1 / u0;
    // double x = u1 / u0;
}

double sumY(double k1x, double x, double b01)
{
    return k1x * x + b01;
    // double y = k1x * x + b01;
}

double x = sumX(b01, k1x, b02, k2x);
double y = sumY(k1x, x, b01);

Console.WriteLine();
Console.WriteLine($"Ответ: точка пересечения находиться здесь -> x = {x}, y = {y} ");
Console.WriteLine();
   