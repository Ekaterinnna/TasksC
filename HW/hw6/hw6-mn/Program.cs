// Задача: 
// Написать программу сложения и вычитания двух многочленов

int[] Sum(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] + g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = g[i];
    else result[i] = f[i];
  }

  return result;
}

int[] Dif(int[] f, int[] g)
{
  int powF = f.Length;
  int powG = g.Length;

  int resultMax = powF;
  int resultMin = powG;

  if (powG > resultMax)
  {
    resultMax = powG;
    resultMin = powF;
  }

  int[] result = new int[resultMax];

  for (int i = 0; i < resultMin; i++)
  {
    result[i] = f[i] - g[i];
  }

  for (int i = resultMin; i < resultMax; i++)
  {
    if (resultMax == powG) result[i] = -g[i];
    else result[i] = f[i];
  }

  return result;
}

string PrintKate(int[] f)
{
  string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
  string output = String.Empty;
  bool firstprint = false;
  for (int i = 0; i < f.Length; i++)
  {

    int t = f[i];
    if (f[i] == 0) continue;
    
    if (i == 0 && f[i] > 0) 
    { 
        output += $"{t}";
        firstprint = true;
    }

    if (i == 0 && f[i] < 0) 
    { 
        output += " - ";
        t = -t;
        output += $"{t}";
        firstprint = true;
    }
    
    if (i == 1 && f[i] < 0) 
    { 
        output += " - ";
        t = -t;
        output += $"{t}x"; 
        firstprint = true;
    }
        else 
        { 
            if (i == 1 && f[i] > 0 && firstprint == true)
            {
            output += " + ";
            output += $"{t}x";
            firstprint = true;
            }
            else if (i == 1 && f[i] > 0 && firstprint == false)
            {
                 output += $"{t}x";
                 firstprint = true;
            }
        }


    if (i != 0 && i != 1 && f[i] < 0) 
    { 
        output += " - ";
        t = -t;
        output += $"{t}x{pows[i]}";
        firstprint = true;
    }
    else if (f[i] > 0 && i != 0 && i != 1 && firstprint == true) 
    {
        output += " + ";
        output += $"{t}x{pows[i]}";
        firstprint = true;
    }
        else if (f[i] > 0 && i != 0 && i != 1 && firstprint == false) 
    {
        output += $"{t}x{pows[i]}";
        firstprint = true;
    }
  }

  return output;
}


int[] m = { 1, 0, 0, 6, -20, 8 };
int[] n = { 0, -5, 0, 0, 7, 3 , 0, -4};

Console.WriteLine();
Console.Write("m(x) = ");
Console.WriteLine(PrintKate(m));
Console.Write("n(x) = ");
Console.WriteLine(PrintKate(n));
Console.WriteLine();

int[] sum = Sum(m, n);
Console.Write("sum(x) = ");
Console.WriteLine(PrintKate(sum));

int[] dif = Dif(m, n);
Console.Write("dif(x) = ");
Console.WriteLine(PrintKate(dif));
Console.WriteLine();