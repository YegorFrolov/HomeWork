/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите любое трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = second (num1);
int second (int num1)
{
    num1 %= 100;
    return num1 / 10;
}
Console.WriteLine("вторая цифра " + result);
