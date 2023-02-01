using System;

public class Laba
{
    public static void Main()
    {
        Console.Write("Введите х1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите х2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("a) " + Math.Pow(x1 * x1 + x2 * x2, 0.5) + "\n");

        Console.Write("Введите х3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("б) " + x1 * x2 + x1 * x3 + x2 * x3 + "\n");

        Console.Write("Введите v: ");
        double v = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите t: ");
        double t = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("в) " + v * t + (a * t * t / 2) + "\n");

        Console.Write("Введите m: ");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите g: ");
        double g = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите h: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("г) " + (m * v * v / 2) + m * g * h + "\n");

        Console.Write("Введите R1: ");
        double r1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите R2: ");
        double r2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("д) " + (1 / r1 + 1 / r2) + "\n");

        Console.Write("Введите alpha: ");
        double alpha = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("е) " + (m * g * Math.Cos(alpha)) + "\n");

        Console.Write("Введите R: ");
        double R = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("ж) " + (2 * Math.PI * R) + "\n");

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("з) " + (b * b - 4 * a * c) + "\n");

        Console.Write("Введите hamma: ");
        double hamma = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите m1: ");
        double m1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите m2: ");
        double m2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите r: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("и) " + hamma * (m1 * m2 / (r * r)) + "\n");

        Console.Write("Введите I: ");
        double i = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("к) " + (i * i * R) + "\n");

        Console.WriteLine("л) " + (a * b * Math.Sin(c)) + "\n");

        Console.WriteLine("м) " + Math.Pow((a * a + b * b - 2 * a * b * Math.Cos(c)), 0.5) + "\n");

        Console.Write("Введите d: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("н) " + (a * d + b * c) / (a * d) + "\n");

        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("о) " + Math.Pow((1 - Math.Pow(Math.Sin(x), 2)), 0.5) + "\n");

        Console.WriteLine("п) " + 1 / Math.Pow((a * x * x + b * x + c), 0.5) + "\n");

        Console.WriteLine("р) " + ((Math.Pow((x + 1), 0.5) + (Math.Pow((x - 1), 0.5))) / (2 * Math.Pow(x, 0.5))) + "\n");

        Console.WriteLine("с) " + Math.Abs(x) + Math.Abs(x + 1) + "\n");

        Console.WriteLine("т) " + Math.Abs(1 - Math.Abs(x)) + "\n"); 
    }
}