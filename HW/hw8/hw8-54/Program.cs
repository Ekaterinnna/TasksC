// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Create(int a, int b)
{
  int[,] table = new int[a, b];
  return table;
}

void Fill(int[,] tab)
{
    int min = 1;
    int max = 10;
    int row = tab.GetLength(0);
    int col = tab.GetLength(1);
    for (int i = 0; i < row; i++)
      for (int j = 0; j < col; j++)
    {
        tab[i,j] = new Random().Next(min, max);
    }
}

string PrintTable(int[,] tab)
{
    string result = string.Empty;
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            result += $"{tab[i, j],3}";
        }
        result += "\n";
    }
    return result;
}



int a = 5;
int b = 5;
int[,] ourtable = Create(a,b);
Fill(ourtable);
Console.WriteLine();
Console.WriteLine(PrintTable(ourtable));
Console.WriteLine();