// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

int NumSquare(int a)
{
    int res = a*a;
    return res;
}

int num = GetNumber("Введите число: ");
for (int i = 1; i <= num; i++)
{
    int sq = NumSquare(i);
    Console.Write($"{sq} ");
}