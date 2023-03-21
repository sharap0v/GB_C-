// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int readConsole(string msg){
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int a = readConsole("Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное. \r\n Введите число");
String result = "";
while(a!=0){
    result = result + a % 2;
    a = a/2;
}
char[] arr = result.ToCharArray();
Array.Reverse(arr);
Console.WriteLine(new string(arr));

