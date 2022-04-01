/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

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

Console.WriteLine("Введите высоту массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = GenerateArray(m, n);
Console.WriteLine("Получаем двумерный массив:");
PrintArray(arr);