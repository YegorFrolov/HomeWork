/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
Console.Clear();
System.Console.Write("Введите колличество строк первой матрицы:");
int row = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите колличество столбцов первой матриц:");
int column = Convert.ToInt32(Console.ReadLine());



Console.WriteLine();
int [,] arr = NewArray(row, column);

System.Console.Write("Введите колличество строк второй матрицы:");
row = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите колличество столбцов второй матрицы:");
column = Convert.ToInt32(Console.ReadLine());

int [,] arr2 = NewArray(row, column);
Console.WriteLine("Пулучаем Матрицы :");
Console.WriteLine();
PrintArray(arr);
Console.WriteLine("__________________________");
PrintArray(arr2);
Console.WriteLine();
Console.WriteLine("Вычисляем произведение матриц ");
Console.WriteLine();
Proizved();



if (arr.GetLength(1) != arr2.GetLength(0))
{
    Console.WriteLine("Невозможно сравнить матрицы т.к. кол-во столбцов первой матрицы должно быть равно кол-ву строк второй");
}

int [,] NewArray(int row, int column)
{
    int [,] newArray = new int [row, column];
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

void Proizved()
{
    int [,] result = new int [arr.GetLength(0) , arr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                result[i,j] += arr[i, k] * arr2[k, j];
            }
        }
    }
    PrintArray(result);
}


