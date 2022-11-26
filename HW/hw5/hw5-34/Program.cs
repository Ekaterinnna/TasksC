// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int GetNumber(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] array)
{
    int size = array.Length;

    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}

string PrintGood(int[] numbers)
{
  int size = numbers.Length;
  int i = 0;
  string result = "[ ";

  while (i < size)
  {
    result += ($"{numbers[i]} ");
    i++;
  }
  return result + "]";
}

int Solution(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] % 2) == 0)
            count++;
    }
    return count;
}

int count = GetNumber("Введите количество чисел в массиве: ");
int[] array = CreateArray(count);
Fill(array);
Console.WriteLine(PrintGood(array));
int even = Solution(array);
Console.WriteLine();
Console.WriteLine(even);
