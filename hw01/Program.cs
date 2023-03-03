// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a);
} else if (b > a) {
    Console.WriteLine(b);
} else {
    Console.WriteLine(a + "=" + b);
}
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число");
int c = Convert.ToInt32(Console.ReadLine());

a = Math.Max(a, b);
a = Math.Max(a, c);
Console.WriteLine("Большее число= " +a);
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
Console.Write(a + " ");
a = a%2;
if(a==1){
    Console.WriteLine("Не четное число");
} else {
    Console.WriteLine("четное число");
}
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N");
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < a; i++)
{
    if((i%2)==0){
        Console.Write(i + " ");
    }
}