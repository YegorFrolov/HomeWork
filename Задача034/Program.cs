/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];

SetArray();
Chet();

void SetArray()
{
   Random rnd = new Random();
   for (int i = 0; i < size; i++)
   {
        array[i] = rnd.Next(100, 1000);
        Console.Write($"{array[i]}, ");
   }
}

void Chet()
{
    int count = 0;
    Console.WriteLine(" ");
    Console.WriteLine("Начинаем отбор чисел");
    for (int i = 0; i < size; i++)
     {
        if (array[i] % 2 == 0)
        {
            count++ ;
            Console.Write(array[i]+" ");
        }
     }
        Console.WriteLine();
        Console.WriteLine($"четных чисел {count}, ");
}


