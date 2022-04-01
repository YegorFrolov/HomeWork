/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

Console.WriteLine("Введите высоту массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива");
int n = Convert.ToInt32(Console.ReadLine());
double [,] arr = GenerateArray(m, n);
Console.WriteLine("Получаем двумерный массив:");
PrintArray(arr);


System.Console.WriteLine("введите номер строки");
int numstr = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите номер столбца");
int numcolon = Convert.ToInt32(Console.ReadLine());

ElementNumber(arr, numstr, numcolon);

if (numstr > m-1 || numcolon > n-1)
    {
        System.Console.WriteLine("элементов с таким номером нет");
    }

double[,] GenerateArray(int hight, int weight)
{
    double[,] array = new double[hight, weight];
    int randomNum = 0;
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            randomNum = new Random().Next(-100,100);
            array[i, j] = (double) randomNum /10;
        }
    }
    return array;
}

void PrintArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void ElementNumber (double [,] array, int numstr, int numcolon)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == numstr-1 && j == numcolon-1)
            {
            Console.WriteLine();
            Console.WriteLine($"в этой ячейке лежит {array[i,j]}");
            }
        }
    }
    
}


