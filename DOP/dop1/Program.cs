/*
Задача 1. Дано предложение. Напишите рекурсивный метод, подсчитывающий количество слов в данном предложении. 
Словом считается последовательность символов без пробелов.
*/
Console.WriteLine("Чтобы посчитать колличество слов введите Ваше предложение:");
string sentence = Convert.ToString(Console.ReadLine());
int i = 0;
int count = 1;
Console.WriteLine($" количество слов - {LetersSum(sentence[i])}");

int LetersSum(char letter)
{
    if (i == sentence.Length - 1)
        return count;
    if (letter == ' ')
    {
        count++;
    }
    i++;
    return LetersSum(sentence[i]);
}

// Вариант 1 считаем слова Console.WriteLine($" колличество символов предложении {sentence.Length}");


/*
Вариант 2 считаем слова

for (int i = 0; i < sentence.Length; i++)
{
    if (sentence[i] == ' ')
    {
        countLetters++;
    }
}
Console.WriteLine($"{countLetters + 1} слова");
*/
