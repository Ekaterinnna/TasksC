// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[index] = new Random().Next(0, 100);
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
    int sum = 0;
    for (int i = 0; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int count = GetNumber("Введите количество чисел в массиве: ");
int[] array = CreateArray(count);
Fill(array);
Console.WriteLine(PrintGood(array));
int sum = Solution(array);
Console.WriteLine();
Console.WriteLine(sum);
