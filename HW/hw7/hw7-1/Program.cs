// Треугольник Паскаля. Вывод многочлена

int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}

void PrintTriangle(int[,] triangle)
{
  int row = triangle.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangle[i, j] != 0)
        Console.Write($"{triangle[i, j],4}");
    }
    Console.WriteLine();
  }
}

int[] GetKoeff(int[,] tr, int pow)
{
  int[] row = new int[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}

string PrintPasPlus(int[] koeff)
{
    string output = String.Empty;
    string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
    if (koeff.Length == 1)
        output += "1";
    if (koeff.Length == 2)
        output += "a + b";
    if (koeff.Length > 2)
    {
    for (int i = 0; i < koeff.Length; i++)
    {
        int powa = koeff.Length - 1 - i;
        int powb = i;
        if (i == 0)
        {
            output += $"a{pows[powa]}";
        }
        else
        {
            if (i != (koeff.Length - 1))
            {
                if (powa == 1 && powb == 1)
                    output += $" + {koeff[i]}⋅a⋅b";                   
                if (powa == 1 && powb != 1)
                    output += $" + {koeff[i]}⋅a⋅b{pows[powb]}";
                if (powb == 1 && powa != 1)
                    output += $" + {koeff[i]}⋅a{pows[powa]}⋅b";
                if (powa != 1 && powb != 1)
                    output += $" + {koeff[i]}⋅a{pows[powa]}⋅b{pows[powb]}";
            }
            else
                output += $" + b{pows[powb]}";
        }
             
    }
    }
    return output;
}

string PrintPasMinus(int[] koeff)
{
    string output = String.Empty;
    string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
     if (koeff.Length == 1)
        output += "1";
    if (koeff.Length == 2)
        output += "a - b";
    if (koeff.Length > 2)
    {
    for (int i = 0; i < koeff.Length; i++)
    {
        int powa = koeff.Length - 1 - i;
        int powb = i;
        if (i == 0)
        {
            output += $"a{pows[powa]}";
        }
        else
        {
            if (i % 2 == 0)
            {
                if (i != (koeff.Length - 1))
                {
                    if (powa == 1 && powb == 1)
                        output += $" + {koeff[i]}⋅a⋅b";                   
                    if (powa == 1 && powb != 1)
                        output += $" + {koeff[i]}⋅a⋅b{pows[powb]}";
                    if (powb == 1 && powa != 1)
                        output += $" + {koeff[i]}⋅a{pows[powa]}⋅b";
                    if (powa != 1 && powb != 1)
                        output += $" + {koeff[i]}⋅a{pows[powa]}⋅b{pows[powb]}";
                }
                else
                    output += $" + b{pows[powb]}";
            }
            else
            {
                if (i != (koeff.Length - 1))
                {
                    if (powa == 1 && powb == 1)
                        output += $" - {koeff[i]}⋅a⋅b";
                    if (powa == 1 && powb != 1)
                        output += $" - {koeff[i]}⋅a⋅b{pows[powb]}";
                    if (powb == 1 && powa != 1)
                        output += $" - {koeff[i]}⋅a{pows[powa]}⋅b";
                    if (powa != 1 && powb != 1)
                        output += $" - {koeff[i]}⋅a{pows[powa]}⋅b{pows[powb]}";
                }
                else
                    output += $" - b{pows[powb]}";
            }
        }   
    }
    }
    return output;
}

string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
int[,] tr = CreateTriangle(10);
PrintTriangle(tr);
int k = 4;
int[] koeff = GetKoeff(tr, k);

Console.WriteLine();
Console.Write($"(a+b){pows[k]} = ");
Console.WriteLine(PrintPasPlus(koeff));
Console.WriteLine();
Console.Write($"(a-b){pows[k]} = ");
Console.WriteLine(PrintPasMinus(koeff));
Console.WriteLine();