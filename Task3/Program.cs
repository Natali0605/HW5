// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = new Random().Next(min, max + 1);  
    }
    return arr;
}

void Difference(int[] number)
{
    int min = number[0];
    int max = number[0];
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] < number[0])
        {
           min = number[i];
        }
        if (number[i] > number[0])
        {
           max = number[i];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");
}

int[] array = CreateMassive(4, 0, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");
Difference(array);