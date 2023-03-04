
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        Console.WriteLine("ввести трехзначное число");
        Console.WriteLine("Вторая цифра " + Convert.ToInt32(Console.ReadLine()) % 100 / 10);

        Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.\r\n" +
        "ДОП: цифра третья может быть как с левой стороны, так и с правой");
        Console.WriteLine("ввести семизначное число");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a / 1000000 == 0)
        {
            Console.WriteLine("Число " + a + " не семизначное");
        }
        else
        {
            Console.WriteLine("Третья цифра с лева " + a % 1000000 % 100000 / 10000 + "\r\n" +
           "Третья цифра с права " + a % 1000000 % 100000 % 10000 % 1000 / 100 + "\r\n");
        }
        Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.\r\n");
        Console.WriteLine("ввести день недели\r\n");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 7 || a == 0 || a < 0)
        {
            Console.WriteLine("Число " + a + " не является днем недели \r\n требуются числа от 1 до 7\r\n");
        }
        else if (a == 6 || a == 7)
        {
            Console.WriteLine(a + " выходной день\r\n");
        }
        else
        {
            Console.WriteLine(a + " будний день\r\n");
        }
    }
}