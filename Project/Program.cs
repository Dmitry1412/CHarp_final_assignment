/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] userArray = { "Hello", "Дима", "World", "487", "Компьютер", "ООП", "мир" };

PrintArray(userArray);
Console.WriteLine();
ReplaceString(userArray);
PrintArray(userArray);

void ReplaceString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) array[i] = "";
    }
}

void PrintArray(string[] array)
{
    foreach (var str in array) Console.Write($"{str} ");
}
