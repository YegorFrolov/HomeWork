/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7"
*/

Console.Write("Введите начальное число ");
int numstart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число ");
int numfinish = Convert.ToInt32(Console.ReadLine());

RecSumm(numstart,numfinish,1);

void RecSumm(int currentnumstart, int currentnumfinish, int itr)
{
    if (currentnumstart > currentnumfinish)
    {
        return;
    }
    else
    {
        Console.WriteLine ($"№{itr} - {currentnumstart}");
        RecSumm(currentnumstart+1, currentnumfinish, ++itr);
    }
}


