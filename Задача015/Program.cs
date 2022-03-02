/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите любую цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if ( num == 6 || num == 7)
{
    Console.WriteLine ("это выходной");
}
else
    {
        if (num <= 5 && num >= 1)
        {
            Console.WriteLine ("это будний день");
        }
        else
        {
           Console.WriteLine ("Кретин, в недели 7 дней");
        }
    }