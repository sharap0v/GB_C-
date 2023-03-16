// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int readConsole(string msg){
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int[] createAndPrintRandomArray(int length, int a, int b){
    Console.Write("[");
    int[] array = new int [length];
    Random random = new Random();
    for (int i = 0; i < length ; i++)
    {
        array[i] = random.Next(a, b);
        Console.Write(array[i]);
        if(i==length-1){
            break;
        }
        Console.Write(", ");
    }
    Console.WriteLine("]");
    return array;
}

int length = readConsole("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.\r\n Напишите программу, которая покажет количество чётных чисел в массиве. \r\n Введите размер массива");
int [] array = createAndPrintRandomArray(length, 100, 999);
int count = 0;
for (int i = 0; i < length; i++)
{
    if(array[i]%2 == 0){
        count++;
    }
}
Console.WriteLine("Количество четных чисел: " + count);

length = readConsole("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. \r\n Введите размер массива");
array = createAndPrintRandomArray(length, 1, 100);
count = 0;
for (int i = 0; i < length; i++)
{
    if(i%2 != 0){
        count = count + array[i];
    }
}

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + count);

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

length = readConsole("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. \r\n Введите размер массива");
array = createAndPrintRandomArray(length, int.MinValue, int.MaxValue);
int min = array[0];
int max = array[0];
for (int i = 0; i < length; i++)
{
    if(min > array[i]){
        min = array[i];
    }
    if(max < array[i]){
        max = array[i];
    }
}
Console.WriteLine("Разница между максимальным и минимальным элементоv массива:" + (max - min));


length = readConsole("Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. \r\n Введите размер массива");
array = createAndPrintRandomArray(length, int.MinValue, int.MaxValue);
int[] result = new int[length/2 + length%2];
Console.WriteLine(length/2 + length%2);
for (int i = 0; i < length/2 + length%2; i++)
{
    Console.WriteLine(array[i] * array[length-1-i]);
    result[i] = array[i] * array[length-1-i];
}
Console.Write("[");
for (int i = 0; i < length/2 + length%2; i++)
{
    Console.Write(result[i]);
    if(i==length/2 + length%2 -1){
        break;
    }
        Console.Write(", ");
}
Console.Write("]");
// Используйте NextDouble().
// Доп. задачка:
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21