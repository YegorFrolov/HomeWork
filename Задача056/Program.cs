/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/
Console.Clear();
System.Console.Write("Введите колличество строк:");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите колличество столбцов:");
int colum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,] arr = NewArray(row, colum);
Console.WriteLine("Пулучаем массив:");
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Вычисляем строку с минимальной суммой: ");
Console.WriteLine();
SumInRow (arr);

int [,] NewArray(int row, int colum)
{
    int [,] newArray = new int [row, colum];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = rnd.Next(1,10);
        }
    }
    return newArray;
}

void PrintArray (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void SumInRow (int [,] array)
{
    int minsum = int.MaxValue;
    int rowind = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];  
        }
        if (sum<minsum)
            {
                minsum = sum;
                rowind = i;
            }
    }
     Console.WriteLine($"строка с и ндексом {rowind+1} - минимальную суммой - {minsum} ");
}
