/*
Задача 29: Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

//Вариант 1
/*
Console.WriteLine("Введите кол-во символов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
int newNumber = 0;
for (int i = 0; i < size; i++)
{
   newNumber = new Random().Next(-100,100);
   Console.Write($"{newNumber}, ");
}
*/

Console.WriteLine("Введите кол-во символов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
int newNumber = 0;

SetArray();

void SetArray()
{
   Random rnd = new Random();
   for (int i = 0; i < size; i++)
   {
      newNumber = rnd.Next(-100,100);
      Console.Write($"{newNumber}, ");
   }
}
