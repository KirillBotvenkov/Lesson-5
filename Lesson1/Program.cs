/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
int GetNumber(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int[] GenerateArray(int length)
{
    int[]answer = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(100,1000);
    }
    return answer;
}

int CountEvenElements(int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Count++;
        }
    }
    return Count;
}

void PrintArray (int[]answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count ++;
    }
    System.Console.WriteLine();
}

int length = GetNumber ("Введите длинну массива >");
int[] array = GenerateArray(length);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел:{CountEvenElements(array)}");
System.Console.WriteLine();