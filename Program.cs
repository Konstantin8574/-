using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Процесс запущен");
        Thread.Sleep(2000);
        Console.WriteLine("5");
        Thread.Sleep(1000);
        Console.WriteLine("4");
        Thread.Sleep(1000);
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.WriteLine("Ракеты были запущены");
    }
}
