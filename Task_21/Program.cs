// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Input("Введите X1: ");
int y1 = Input("Введите Y1: ");
int z1 = Input("Введите Z1: ");
int x2 = Input("Введите X2: ");
int y2 = Input("Введите Y2: ");
int z2 = Input("Введите Z2: ");

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками: {result}");

