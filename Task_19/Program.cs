// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Input("Введите пятизначное число: ");
int a = number / 10000;
int b = number % 10;
int c = number / 1000 % 10;
int d = number / 10 % 10;
if (number > 9999 && number < 100000)
{
    if (a == b && c == d) Console.WriteLine($"Число {number} является ПАЛИНДРОМОМ");
    else Console.WriteLine($"Число {number} НЕ является ПАЛИНДРОМОМ");
}
else Console.WriteLine("Необходимо ввести пятизначное число!");