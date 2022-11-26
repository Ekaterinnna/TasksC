// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int GetNumber(string text)
{
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[] CreateArray(int count)
{
    return new double[count];
}

void Fill(double[] array)
{
    int size = array.Length;

    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(0, 100);
        index++;
    }
}

string PrintGood(double[] numbers)
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

double FindMax(double[] arr)
{
    int len = arr.Length;
    double max = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (max < arr[i])
            max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    int len = arr.Length;
    double min = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (min > arr[i])
            min = arr[i];
    }
    return min;
}

int count = GetNumber("Введите количество элементов в массиве: ");
double[] array = CreateArray(count);
Fill(array);
Console.WriteLine(PrintGood(array));
double max = FindMax(array);
double min = FindMin(array);
double res = max - min;
Console.WriteLine(res);