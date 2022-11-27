// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[5];

for (int i = 0; i < a.Length; i++)
{
    a[i] = n % 10;
    n = n / 10;
}

if ((a[0] == a[4]) && (a[1] == a[3]))
{
    Console.WriteLine("да");
}
else Console.WriteLine("нет");