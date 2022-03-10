/*
Ввести число в двоичной системи счисления и определить сколько единиц и нулей
*/

Console.WriteLine("Введите любую цифру от 1 до 7");
string num = Conver.ToString(Console.ReadLine());

int Count1 = 0;
int Count2 = 0;

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