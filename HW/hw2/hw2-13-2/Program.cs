// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string a = Convert.ToString(n);
    Console.Write(a[2]);
}