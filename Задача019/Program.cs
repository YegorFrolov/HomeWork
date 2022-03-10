/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите любое пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int proverka = Count(num);

string num1 =  Convert.ToString(num);
char[] obrnum = num1.ToCharArray();
Array.Reverse(obrnum);
string finalnum = new string(obrnum);

if (proverka == 5)
{
    if(num1==finalnum)
    {
        Console.WriteLine("Число "+ num + " палиндром");
    }
    else
    {
        Console.WriteLine("Число "+ num + " не палиндром");
    }

}
else
{
    Console.WriteLine("Число "+ num + " не пятизначное");
}


int Count (int number)
{
    int countznak = 0;
    while (number>0)
        {
            number/=10;
            countznak++;
        }
        return countznak;
}