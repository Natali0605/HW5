// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateMassive(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = new Random().Next(min, max + 1);  
    }
    return arr;
}

void SumNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            result = result + arr[i];
        }
    }
    Console.Write(result);
}

int[] array = CreateMassive(4, 0, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");
SumNumbers(array);
