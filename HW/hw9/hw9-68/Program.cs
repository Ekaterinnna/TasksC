// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

int Ack(int n, int m)
{
    if (n == 0)
        return m+1;
    else if (m == 0)
        return Ack(n-1, 1);
        else return Ack(n-1, Ack(n, m-1));
}

int m = GetNumber("Введите число m = ");
int n = GetNumber("Введите число n = ");
int ack = Ack(m, n);
Console.WriteLine();
Console.WriteLine(ack);