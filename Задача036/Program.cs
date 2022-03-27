/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.WriteLine("Введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];

array = SetArray(array);
ChetPoz(array);

int[]SetArray(int[]array)
{
   Random rnd = new Random();
   for (int i = 0; i < size; i++)
   {
        array[i] = rnd.Next(-100,100);
        Console.Write($"{array[i]}, ");
   }
   return array;
}

void ChetPoz (int[]Array)
{
    Console.WriteLine(" ");
    Console.WriteLine("Начинаем отбор чисел");
    int sum = 0;
    for (int i = 1; i < size; i+=2)
    {
        sum += array[i];
    }
        Console.WriteLine();
        Console.WriteLine($"Сумма нечетных чисел {sum}, ");
}
*/

int [] MakeRandomArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


void CountEvenNumbers (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел в этом массиве = {count}.");
}


void PrintArray (int[] array)
{
    Console.WriteLine("Случайный массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}


Console.Clear();
System.Console.WriteLine("Укажите длину массива.");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arrayLength];
myArray = MakeRandomArray(myArray);
PrintArray(myArray);
CountEvenNumbers(myArray);
