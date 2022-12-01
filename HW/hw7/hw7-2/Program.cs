// Треугольник Паскаля. Вывод нечетных чисел

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

void PrintTriangleStar(int[,] triangle)
{
    int row = triangle.GetLength(0);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] % 2 != 0)
                Console.Write("*");
            else
            {
                if (j == (row - 1))
                    Console.WriteLine(" ");
                else Console.Write(" ");
            }
        }
    }
}

int[,] trian = CreateTriangle(10);
PrintTriangle(trian);

int[,] tr = CreateTriangle(80);
PrintTriangleStar(tr);