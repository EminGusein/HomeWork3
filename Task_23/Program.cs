// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Input("Введите число: ");

int count = 1;
while (count <= num)
{
    Console.WriteLine($"{count}^3 = {Math.Pow(count, 3)} ");
    count = count + 1;
}