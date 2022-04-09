/*
Задача 62: Заполните спирально массив 4 на 4.
*/


Console.Clear();
Console.Write("Введите размер квадратной матрицы ");
int row = Convert.ToInt32(Console.ReadLine()); 

int column = row; 

int number = 1; // первый элемент массива

Console.WriteLine(string.Empty);

Print2(SpiralArray(row, column, number));

Console.WriteLine("\n"); Console.ReadKey();

static int[,] SpiralArray(int row, int column, int number)
{
int[,]array = new int[row,column];
int count = 0; // счётчик пройденных витков спирали
int rownow; int columnnow; // строка и столбец текущего элемента массива
while (number < row*column + 1)
{
    for (columnnow = count; columnnow < column - count; columnnow++) array[count, columnnow] = number++; // верхняя горизонталь витка спирали, слева направо
    for (rownow = count + 1; rownow < row - count; rownow++) array[rownow, row - count - 1] = number++; // правая вертикаль витка спирали, сверху вниз
    for (columnnow = column - count - 2; columnnow > count; columnnow--) array[column - count - 1, columnnow] = number++; // нижняя горизонталь витка спирали, справа налево
    for (rownow = row - count - 1; rownow > count; rownow--) array[rownow,count] = number++; // левая вертикаль витка спирали, снизу вверх
count++;
}
return array;
}

static void Print2(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + "\t");
        }
        Console.WriteLine();
    }
}