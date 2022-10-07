// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да
// 23432 -> да

int N;

Console.WriteLine("Введите пятизначное число (от 9 999 до 99 999):");
int.TryParse(Console.ReadLine()!, out N);

if (N / 10000 == N % 10 && N / 1000 % 10 == N / 10 % 10)
{
    Console.WriteLine($"{N} - это палиндром");
}
else
{
    Console.WriteLine($"{N} - это НЕ палиндром");
}

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

A(3, 6, 8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53

int[] A = new int[3];
int[] B = new int[3];
int[] C = new int[3];


Console.WriteLine("Введите координату X первой точки:");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.WriteLine("Введите координату Y первой точки:");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.WriteLine("Введите координату Z первой точки:");
int.TryParse(Console.ReadLine()!, out A[2]);

Console.WriteLine("Введите координату X второй точки:");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.WriteLine("Введите координату Y второй точки:");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.WriteLine("Введите координату Z второй точки:");
int.TryParse(Console.ReadLine()!, out B[2]);

double d = Math.Sqrt(Math.Pow((A[0] - B[0]), 2) + Math.Pow((A[1] - B[1]), 2) + Math.Pow((A[2] - B[2]), 2));

Console.Write($"Расстояние между точками составляет {d}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int i = 1; i <= N; i++)
{
    Console.Write($"{(int)Math.Pow(i, 3)} ");
}

