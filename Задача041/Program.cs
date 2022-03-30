/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.WriteLine("Введите желаемое кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double[size];


array = SetArray(array);

otbor (array);



double [] SetArray(double[]array)
{
   for (int i = 0; i < size; i++)
   {
        
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
   }
return array;    
}
void otbor (double[]Array)
{
    Console.WriteLine(" ");
    Console.WriteLine("Начинаем отбор чисел");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }

    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}
