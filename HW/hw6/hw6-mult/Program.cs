// Перемножение двух многочленов

int[] Multipl(int[] f, int[] g)
{
    int t = f.Length + g.Length;
    int[] m = new int[t];
    for (int i = 0; i < f.Length; i++)
        for (int j = 0; j < g.Length; j++)
        {
            m[i+j] = m[i+j] + f[i]*g[j];
        }
    return m;
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


int[] m = { 1, 0, 3 };
int[] n = { 7, 3, -4};

Console.WriteLine();
Console.Write("m(x) = ");
Console.WriteLine(PrintKate(m));
Console.Write("n(x) = ");
Console.WriteLine(PrintKate(n));
Console.WriteLine();

int[] mult = Multipl(m, n);
Console.Write("mult(x) = ");
Console.WriteLine(PrintKate(mult));

Console.WriteLine();