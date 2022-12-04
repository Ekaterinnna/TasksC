// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] ThreeDArray(int a, int b, int c)
{
    int[,,] newarray = new int[a,b,c];
    return newarray;
}

void FillArray(int[,,] array)
{
    int min = 10;
    int max = 100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            {
                label:
                int value = new Random().Next(min, max);
                for (int m = 0; m < i+1; m++)
                    for (int n = 0; n < j+1; n++)
                        for(int p = 0; p < k+1; p++)
                        {
                            if (array[m,n,p] == value)
                            {
                                goto label;
                            }
                        }
                array[i,j,k] = value;
            }
}

string PrintTable(int[,,] tab)
{
    string result = string.Empty;
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            for(int k = 0; k < tab.GetLength(2); k++)
            {
                result += $"{tab[i, j, k],3}({i},{j},{k}) ";
            }
            result += "\n";
        }
    }
    return result;
}

int a = 2;
int b = 2;
int c = 2;
int[,,] myarray = ThreeDArray(a,b,c);
FillArray(myarray);
Console.Write(PrintTable(myarray));