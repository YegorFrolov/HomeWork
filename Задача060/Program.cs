/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/ 

Console.Clear();
Console.Write("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество диагоналей:");
int diagon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int [,,] arr = NewArray(row, column, diagon);
Console.WriteLine("Пулучаем массив:");
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();



int [,,] NewArray(int row, int column, int diagon)
{
    int [,,] newArray = new int [row, column, diagon];
    int ctr = 10;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i,j,k] = ctr++;
            }
        }
    }
    return newArray;
}

void PrintArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} [{i},{j},{k}] \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
