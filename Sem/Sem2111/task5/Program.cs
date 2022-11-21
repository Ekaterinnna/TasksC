// 5 - Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 1. Ввод чисел a и b
// 2. Найти квадраты sqa=a*a и sqb=b*b
// 3. Определяем a == sqb и b == sqa -?
// 4. Выводим результат

int a = 0;
int b = 0;
Console.WriteLine(a);
Console.WriteLine(b);

int sqa = a*a;
int sqb = b*b;

if (a == sqb)
{
    Console.WriteLine("Число a является квадратом числа b");
    if (b == sqa)
    {
        Console.WriteLine("Число b является квадратом числа a");
    }
}
else 
{
    if (b == sqa)
    {
        Console.WriteLine("Число b является квадратом числа a");
    }
}