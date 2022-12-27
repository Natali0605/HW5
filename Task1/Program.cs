// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = new Random().Next(min, max + 1);  
    }
    return arr;
}

void EvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count ++;
        }
    }
    Console.Write(count);
}

int[] array = CreateMassive(10, 99, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");
EvenNumbers(array);
