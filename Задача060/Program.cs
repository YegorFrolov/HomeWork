/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
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
SortArray (arr);
Console.WriteLine("Сортируем массив по убыванию:");
Console.WriteLine();
PrintArray(SortArray(arr));

int [,] NewArray(int row, int colum)
{
    int [,] newArray = new int [row, colum];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = rnd.Next(1,100);
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
