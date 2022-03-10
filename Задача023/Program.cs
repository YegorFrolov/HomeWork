/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int numcub = 1;
int cub = 3;

if (num <=0 )
{
    Console.WriteLine("введите число больше ноля");
}

for (int i= 1; i<=num; i++)
{
    numcub=Convert.ToInt32(Math.Pow(i,cub));
    Console.WriteLine($"Число {i} в кубе - равно {numcub}");
}