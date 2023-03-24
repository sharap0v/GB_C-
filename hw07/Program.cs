// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int readConsole(string msg){
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int a = readConsole("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. \r\nВведите первое число");
int b = readConsole("Введите второе число");

int[,] createArray(int a, int b, int min, int max){
    int[,] array = new int[a, b];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = random.Next(min, max);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
    return array;
}
int[,] array = createArray(a, b, int.MinValue, int.MaxValue);


a = readConsole("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. \r\n Введите первое число");
b = readConsole("Введите второе число");

void printArrayElement(int[,] array, int a, int b){
    try{
        Console.WriteLine(array[a, b]);
    } catch (System.IndexOutOfRangeException e){
        Console.WriteLine(e);
        Console.WriteLine("такого элемента нет");
    }
}
printArrayElement(array, a, b);

a = readConsole(" Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\r\n Введите первое число");
b = readConsole("Введите второе число");
array = createArray(a, b , 0, 10);

void printAverageOfEachColumn(int[,] array, int a, int b){
    Console.Write("Среднее арифметическое каждого столбца: ");
        for (int i = 0; i < b; i++)
    {
        double result = 0;
        for (int j = 0; j < a; j++)
        {
            result = result + array[j, i];
        }
        Console.Write(result +"  "+(result / a) + "; ");
    }
}
printAverageOfEachColumn(array, a, b);