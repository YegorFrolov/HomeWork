/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
Console.WriteLine("Введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double[size];

array = SetArray(array);
 delta(array);

double[]SetArray(double[]array)
{
   Random rnd = new Random();
   for (int i = 0; i < size; i++)
   {
        array[i] = rnd.NextDouble();
        Console.Write($"{array[i]}, ");
   }
   return array;
}

void delta (double[]Array)
{
    Console.WriteLine(" ");
    Console.WriteLine("Начинаем отбор чисел");
    double max = array[0];
    double min = array[0];
    double different = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
        else if(min > array[i])
        {
            min = array[i];
        }
    }
    different = max-min;
    Console.WriteLine();
    Console.WriteLine($"максимальное значение {max}, минимальное значение {min} их разница {different} ");
}