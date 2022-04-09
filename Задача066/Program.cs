/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите начальное число ");
int numstart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число ");
int numfinish = Convert.ToInt32(Console.ReadLine());
int sum = 0;
RecSumm(numstart,numfinish,sum);

void RecSumm(int currentnumstart, int currentnumfinish, int sum)
{
    
    if (currentnumstart > currentnumfinish)
    {
        Console.WriteLine ($" сумма элементов от {numstart} до {numfinish} = {sum}");
        return;
    }
    else
    {
        sum+=currentnumstart;
        RecSumm(currentnumstart+1, currentnumfinish,sum);
    }
}
