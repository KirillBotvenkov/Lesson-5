/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int GetNumber(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
double[] GenerateArray(int length, int min, int max)
{
    double[]answer = new double[length];
     Random rnd = new Random();
     for (int i = 0; i < answer.Length; i++)
     {
        answer[i] = rnd.NextDouble() + rnd.Next(min,max);
     }
     return answer;
}
double Max(double[] array)
{
    double max = array[0];
    for(int i = 1; i <array.Length; i++){
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
double Min(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++){
        if (min > array[i])
        {
            min = array[i];
        }
    }
     return min;
}

double CalcDifferenceBetweenMaxMin(double[]array)
{
    return Max(array) - Min(array);

}

void PrintArray(double[]answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}

const int limitMin = 0;
const int limitMax = 10;

int length = GetNumber("Введите длинну массива: ");
double[] array = GenerateArray(length,limitMin,limitMax);
PrintArray(array);
System.Console.WriteLine
($"Разность между макимальнам и минимальным значением = {CalcDifferenceBetweenMaxMin(array):f2}");
 
 System.Console.WriteLine();