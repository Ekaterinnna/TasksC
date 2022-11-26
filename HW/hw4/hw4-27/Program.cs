// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber(string text)
   {
    Console.Write(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
   }

int SumNum(int number)
{
    string arr = Convert.ToString(number);
    int length = arr.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        result = result + Convert.ToInt32(Char.GetNumericValue(arr[i]));
    }
    return result;
}


int A = GetNumber("Введите А = ");
int sum = SumNum(A);
Console.WriteLine();
Console.WriteLine(sum);
