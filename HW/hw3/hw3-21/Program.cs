// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double[] GetCoordinates (string text)
{
    double[] coord = new double[3];
    Console.Write(text);
    Console.WriteLine();
   
    Console.Write("Первая координата:");
    coord[0] = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Вторая координата:");
    coord[1] = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Третья координата:");
    coord[2] = Convert.ToDouble(Console.ReadLine());
    return coord;
}

double Distance(double[] arr1, double[] arr2)
{
    double sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr2[i] - arr1[i])*(arr2[i] - arr1[i]);
    }
    double dist = Math.Sqrt(sum);
    dist = Math.Round(dist, 2);
    return dist;
}

double[] A = GetCoordinates ("Введите координаты точки A");
double[] B = GetCoordinates ("Введите координаты точки B");
double res = Distance(A, B);
Console.WriteLine();
Console.WriteLine(res);
