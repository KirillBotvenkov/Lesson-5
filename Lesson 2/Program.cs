/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
        answer[i] = rnd.Next(0,10);
    }
    return answer;
}

int SumEllements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i+2)
{
        sum+= array[i];
}
    return sum;
}

void PrintArray(int[]answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count ++;
    }
    System.Console.WriteLine();
}

int length = GetNumber ("Введите длинну массива ");
int[] array = GenerateArray(length);
PrintArray(array);
System.Console.WriteLine($"Количество нечетных чисел:{SumEllements(array)}");
System.Console.WriteLine();





