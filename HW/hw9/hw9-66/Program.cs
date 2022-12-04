// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

int SumNumbers(int a, int b)
{
    int i = 0;
    int max = 0;
    if (a < b)
    {
        i = a;
        max = b;
    }
    else 
    {
        i = b;
        max = a;
    }
    int sum = i;
    if ( i < max)
        {
        sum = sum + SumNumbers(i + 1, max);
        return sum;
        }
    else
        return max;
}

int N = GetNumber("Введите число N = ");
int M = GetNumber("Введите число M = ");
int sum = SumNumbers(N, M);
Console.WriteLine();
Console.WriteLine(sum);