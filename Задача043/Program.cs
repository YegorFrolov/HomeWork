/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
/*
Console.Clear();
Console.Write($"Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Получаем следующие функции для сравнения: ");
Console.WriteLine($"y={k1}*x+{b1}");
Console.WriteLine();
Console.WriteLine($"y={k2}*x+{b2}");
Console.WriteLine("Решаем");

Console.WriteLine($"{k1}x+{b1}={k2}x+{b2}");
double k1mink2 = k1-k2;
double b1minb2 = b2 - b1;
Console.WriteLine($"{k1}x-({k2}x)={b2}-({b1})");
double x = b1minb2/k1mink2;
Console.WriteLine($"{k1mink2}/{k1mink2} = {b1minb2}/{k1mink2}");
Console.WriteLine($"Нашил х = {x}");
 
Console.WriteLine($"Заменяем х на {x} в уравнениях");
double y1 =k1*x+b1;
double y2 =k2*x+b2;
Console.WriteLine($"y = {k1}*{x}+{b1}  y = {k2}*{x}+{b2}");

Console.WriteLine($"Нашил y1 = {y1}");
Console.WriteLine($"Нашил y2 = {y2}");
if (y1==y2)
{
    Console.WriteLine ($"Функции пересекаются в точке {x},{y1}");
}
else
{
    Console.WriteLine ($"Функции не пересекаются");
}
*/

Console.Clear();
Console.Write($"Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double k1mink2 = k1-k2;
double b1minb2 = b2 - b1;
double x = b1minb2/k1mink2;
double y1 =k1*x+b1;
double y2 =k2*x+b2;
if (y1==y2)
{
    Console.WriteLine ($"Функции пересекаются в точке {x},{y1}");
}
else
{
    Console.WriteLine ($"Функции не пересекаются");
}