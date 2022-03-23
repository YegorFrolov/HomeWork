/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Вариант 1 
Console.WriteLine("Введите первое число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int i = Convert.ToInt32(Math.Pow(num, num2));
Console.WriteLine($"Число {num} в степени {num2} равно {i}");

Двузначные числа не переваривает
Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.
   at System.Convert.ToInt32(Double value)
   at Program.<Main>$(String[] args) in /Users/egorfrolov/Desktop/Программирование/Домашка/Задача025/Program.cs:line 22

*/

//Вариант 2

Console.WriteLine("Введите первое число:");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double num2 = Convert.ToDouble(Console.ReadLine());
double i = Convert.ToDouble(Math.Pow(num, num2));
Console.WriteLine($"Число {num} в степени {num2} равно {i}");

