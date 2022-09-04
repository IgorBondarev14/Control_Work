// Написать программу, которая из имеющегося массива строк формирует массив из строк,длинна которых
//меньше, либо равна 3.

Console.Write("Введите количество элементов изначального массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
    while (n < 1)
    {
        Console.WriteLine("Количество элементов массива не может быть отрицательным или равным нулю: ");
        Console.Write("Введите количество элементов изначального массива: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
string[] Array = new string[n];
Console.Write("Введите максимальный размер искомых элементов массива: ");
int search = Convert.ToInt32(Console.ReadLine());
if (search < 1)
{
    while (search < 1)
    {
        Console.WriteLine("Длина элементов массива не может быть отрицательной или равной нулю: ");
        Console.Write("Введите максимальный размер искомых элементов массива: ");
        search = Convert.ToInt32(Console.ReadLine());
    }
}    
for (int i = 0; i < n; i++)
{
    Console.Write("Введите " + i + " элемент массива: ");
    Array[i] = Convert.ToString(Console.ReadLine());
}

Console.WriteLine("Ваш массив: ");
Console.WriteLine("[" + string.Join(", ", Array) + "]");
int j = 0;
for (int i = 0; i < n; i++)
{
    if (Array[i].Length <= search)
        j++;
}

string[] NewArray = new string[j];
int k = 0;
for (int i = 0; i < n; i++)
{
    if (Array[i].Length <= search)
    {
        NewArray[k] = Array[i];
        k++;
    }
}

Console.WriteLine("[" + string.Join(", ", NewArray) + "]");
