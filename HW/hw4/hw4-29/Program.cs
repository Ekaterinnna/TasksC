// Задача 29: Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.

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
    array[index] = GetNumber($"array[{index}]: ");
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

Console.WriteLine("Введите данные массива:");
int count = 8;
int[] ourArr = CreateArray(count);
Fill(ourArr);
Console.WriteLine(PrintGood(ourArr));
