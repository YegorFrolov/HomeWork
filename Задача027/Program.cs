/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
Нашел в тырнете
int result = 452.ToString().Sum(c => c - '0');
Console.WriteLine(result);
Как работает не понятно =/
*/

/*
Вариант 1
Console.WriteLine("Введите любое число: ");
string numstr = Convert.ToString(Console.ReadLine());
int sum = 0;
sum = numstr.Sum(i => i - '0');
Console.WriteLine(sum);
*/

Console.WriteLine("Введите любое число: ");
string num = Convert.ToString(Console.ReadLine());
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    int number = Convert.ToInt32(num[i].ToString());
    sum += number;
}
Console.WriteLine(sum);
