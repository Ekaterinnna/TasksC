// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int a = n / 100;
if (a == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int k = 0;
    int r = n;
    while (r != 0)
    {
        r = r / 10;
        k++;
    }
    Console.WriteLine($"Знаков в числе {k}");
    if (k == 3)
    {
        int t = n % 10;
        Console.WriteLine($"Третья цифра = {t}");
    }
    else
    {
        int p = k - 3;
        int y = Convert.ToInt32(Math.Pow(10, p));
        int t = (n / y) % 10;
        Console.WriteLine($"Третья цифра = {t}");
    }
}
