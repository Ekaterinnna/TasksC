// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
/*
1. Создание массива
2. Заполнение массива
3. Вывод массива
4. Метод создания нового перевернутого массива, если возможно
*/

int[,] Create(int a, int b)
{
  int[,] table = new int[a, b];
  return table;
}

void Fill(int[,] tab)
{
    int min = 1;
    int max = 100;
    int row = tab.GetLength(0);
    int col = tab.GetLength(1);
    for (int i = 0; i < row; i++)
      for (int j = 0; j < col; j++)
    {
        tab[i,j] = new Random().Next(min, max);
    }
}

void PrintTable(int[,] tab)
{
  int row = tab.GetLength(0);
  int col = tab.GetLength(1);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      Console.Write($"{tab[i, j],4}");
    }
    Console.WriteLine();
  }
}

int[,] TurnTable(int[,] tab)
{
  int row = tab.GetLength(0);
  int col = tab.GetLength(1);
  int[,] turnt = new int[col,row];
  if (row == col)
  {
    for (int i = 0; i < col; i++)
      for (int j = 0; j < row; j++)
      {
        turnt [i,j] = tab [j,i];
      }
  }
  return turnt;
}

int a = 5;
int b = 5;
int[,] ourtable = Create(a,b);
Fill(ourtable);
Console.WriteLine();
PrintTable(ourtable);
Console.WriteLine();

if (a == b)
{
  ourtable = TurnTable(ourtable);
  Console.WriteLine();
  PrintTable(ourtable);
  Console.WriteLine();
}
else Console.WriteLine("Заменить строки на столбцы невозможно");