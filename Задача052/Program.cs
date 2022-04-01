/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

System.Console.Write("Введите колличество строк:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите колличество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [,] arr = GenerateArray(m,n);
PrintArray(arr);
System.Console.WriteLine();
Mean(arr);

int [,] GenerateArray (int weight, int height)
{
    int [,] array = new int [weight,height];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);;
        }
    }
    return array;
}

void PrintArray (int [,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i,j]} \t ");
        }
        Console.WriteLine();
    }
}

void Mean (int [,] array)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    int j = 0;
    while (j < array.GetLength(1))
    {
    double sum = 0;
    double meansum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,j];
    }
    meansum = sum / array.GetLength(1);
    Console.Write($"{meansum}, ");
    j++;
    }  
}


