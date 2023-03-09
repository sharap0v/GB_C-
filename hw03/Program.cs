

Console.WriteLine("Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

String a = new String(Console.ReadLine());

String result = " палиндромом";
//определит любой текст является ли палиндромом, число это частный случай
for (int i = 0; i < a.Length / 2; i++)
{
    if (a[i] != a[a.Length - 1 - i])
    {
        result = " не" + result;
        break;
    }
}
Console.WriteLine(a + result);

Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.Write("Введите координату первой точки по оси Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Растояние между точками " + Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2)));

Console.WriteLine("Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("кубы чисел \t");
for (int i = 1; i <= x; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}

Console.WriteLine("\r\nДоп. задание №1: Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада.\r\n" +
"На вход будет подаваться число (сумма вклада).\r\n " +
"При значении меньше 100, будет начислено 5 %,\r\n" +
"если значение находится в диапазоне от ста до двухсот — 7 %,\r\n" +
" если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.\r\n");
x = Convert.ToInt32(Console.ReadLine());
if (x < 100)
{
    Console.WriteLine(100 * 1.05);
}
else if (x >= 100 && x <= 200)
{
    Console.WriteLine(100 * 1.07);
}
else
{
    Console.WriteLine(100 * 1.1);
}
Console.WriteLine("Доп. задание №2:" +
"Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по РАСПОЛОЖЕНИЮ цифре." +
" Напишите программу, которая определяет интересное число или нет. " +
"Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».");
a = Console.ReadLine();
if (a.Length % 2 != 1)
{
    Console.WriteLine(a + " Число неинтересное");
}
else
{
    int average = Convert.ToInt32(new String ( a[a.Length / 2], 1));
    int min = Convert.ToInt32(new String (a[0], 1));
    int max = Convert.ToInt32(new String (a[0], 1));
    for (int i = 1; i < a.Length; i++)
    {
        if (Convert.ToInt32(new String (a[i], 1)) > max)
        {
            max = Convert.ToInt32(new String (a[i], 1));
        }
        if (Convert.ToInt32(new String (a[i], 1)) < min)
        {
            min = Convert.ToInt32(new String (a[i], 1));
        }
    }

    if (average == max - min)
    {
        Console.WriteLine(a + " Число интересное!!");
    }
    else
    {
        Console.WriteLine(a + " Число неинтересное!");
    }
    Console.WriteLine("average " + average );
    Console.WriteLine("max " + max );
    Console.WriteLine("min " + min );
}