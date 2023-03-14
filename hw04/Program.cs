// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");

int readConsole(string msg){
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
double exponentiation(int number, int exp){

    double result = 1;
        if(exp==0){
        return result;
    }
    for (int i = 0; i < Math.Abs(exp) ; i++)
    {
        result = result * number;
    }
    if(exp<0){
        result = 1 / result;
    }
    return result;
}
int sumNumbersInNumber(int number){
    int result = 0;
    number = Math.Abs(number);
    while(number>0){
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}
int[] createAndPrintRandomArray(int length){
    Console.Write("[");
    int[] array = new int [length];
    Random random = new Random();
    for (int i = 0; i < length ; i++)
    {
        array[i] = random.Next();
        Console.Write(array[i]);
        if(i==length-1){
            break;
        }
        Console.Write(", ");
    }
    Console.WriteLine("]");
    return array;
}
Console.WriteLine(exponentiation(readConsole("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B\r\n Введите число "), readConsole("Введите степень числа ")));
Console.WriteLine(sumNumbersInNumber(readConsole("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\r\n Введите число ")));
Console.WriteLine(createAndPrintRandomArray(readConsole("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\r\n Введите длинну массива ")));





// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]