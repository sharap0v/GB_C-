// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
        int M = ReadConsole("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. \r\nВведите M");
        int N = ReadConsole("Введите N");
        MethodsForNaturalNumbers(M, N, Method.Print);
        M = ReadConsole("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. \r\nВведите M");
        N = ReadConsole("Введите N");
        MethodsForNaturalNumbers(M, N, Method.Sum);
        M = ReadConsole("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. \r\nВведите M");
        N = ReadConsole("Введите N");
        MethodsForNaturalNumbers(M, N, Method.Akkerman);
    }

    public enum Method
    {
        Sum,
        Print,
        Akkerman
    }
    static int ReadConsole(string msg)
    {
        //привык именовать методы так  readConsole возможно в С# принять по другому
        Console.WriteLine(msg);
        int a = Convert.ToInt32(Console.ReadLine());
        return a;
    }
    static void MethodsForNaturalNumbers(int M, int N, Method m)
    {
        if (N > 0 && M > 0)
        {
            switch (m)
            {
                case Method.Sum:
                    int sum = 0;
                    if (N > M)
                    {
                        for (int i = M; i <= N; i++)
                        {
                            sum = sum + i;
                        }
                    }
                    else if (N < M)
                    {
                        for (int i = M; i >= N; i--)
                        {
                            sum = sum + i;
                        }
                    }
                    else
                    {
                        sum = N;
                    }
                    Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = " + sum);
                    break;
                case Method.Print:
                    if (N > M)
                    {
                        for (int i = M; i <= N; i++)
                        {
                            Console.Write(i);
                            if (i == N)
                            {
                                Console.WriteLine();
                                return;
                            }
                            Console.Write(", ");
                        }
                    }
                    break;
                case Method.Akkerman:
                    Console.WriteLine("A(" + M + "," + N + ") = " + Akkerman(M, N));
                    break;
            }
        }
        else
        {
            Console.WriteLine("Число М или N не натуральное ");
        }
    }

    static int Akkerman(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return Akkerman(n - 1, 1);
        else
            return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}