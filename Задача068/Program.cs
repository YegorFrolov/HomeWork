/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/ 

Console.Write("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());


int Ackerman(int ackm, int ackn)
{
    
    if (ackm==0)
    {
        return ackn+1;
    }
    else if (ackn==0)
    {
        return Ackerman(ackm-1,1);
    }
    else
    {
        return Ackerman(ackm-1,Ackerman(ackm,ackn-1));
    }
}
Console.WriteLine(Ackerman(m,n));