// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя

int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

int PowerNum(int num, int pow)
{
        int result = num;
    for ( int i = 1; i < pow; i++)
    {
        result = result * num;
    }
    return result;
}

int A = GetNumber("Введите А = ");
int B = GetNumber("Введите В = ");
int p = PowerNum(A, B);
Console.WriteLine();
Console.WriteLine(p);