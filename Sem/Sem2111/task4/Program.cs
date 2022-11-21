// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 1. Ввести число
// 2. Проверка остатка от деления на 7
// 3. Проверка остатка от деления на 23
// 4. Вывести кратно/некратно

int n = 161;

int rem7 = n % 7;
int rem23 = n % 23;

Console.WriteLine(rem7);
Console.WriteLine(rem23);

if (rem7 == 0)
{
    if (rem23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else  Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Нет");
}
