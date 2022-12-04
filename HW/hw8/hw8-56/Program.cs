// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] ArrayOfSums(int[,] tab)
{
    int k = tab.GetLength(0);
    int[] arsum = new int[k];
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            arsum[i] = arsum[i] + tab[i, j];
        }
    }
    return arsum;
}

int MinSum(int[] k)
{
    int minsum = k[0];
    int minsumindex = 0;
    for (int i = 0; i < k.Length; i++)
    {
        if(minsum > k[i])
        {
            minsum = k[i];
            minsumindex = i;
        }
    }
    return minsumindex;
}

int a = 3;
int b = 4;
int[,] ourtable = Create(a,b);
Fill(ourtable);
Console.WriteLine();
Console.WriteLine(PrintTable(ourtable));
Console.WriteLine();

int[] sumarray = ArrayOfSums(ourtable);
int rownumber = MinSum(sumarray);
Console.WriteLine($"Номер строки с минимальной суммой:{rownumber+1}");