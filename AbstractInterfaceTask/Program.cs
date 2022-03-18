using AbstractInterfaceTask.Models;
using System;

namespace AbstractInterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            do
            {
                Console.WriteLine(@"0-Proqramı dayandırır
1-Kvadratın sahəsini tapan metod
2-Düzbucaqlının sahəsini tapan metod");
                Console.Write("Bir seçim edin: ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Kvadratın sahəsinin tapılması...");
                        double side = 0;
                        SquareValue(ref side);
                        Square square = new Square(side);
                        Console.WriteLine($"Tərəfi {square.Side} olan kvadratın sahəsi = {square.CalcArea()}");
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Düzbucaqlının sahəsinin tapılması...");
                        double width = 0, length = 0;
                        RectangularValue(ref width, ref length);
                        Rectangular rectangular = new Rectangular(width, length);
                        Console.WriteLine($"Eni {rectangular.Width} uzunluğu {rectangular.Length} olan düzbucaqlının sahəsi = {rectangular.CalcArea()}");
                        Console.WriteLine("---------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Yanlış məlumat daxil edildi");
                        break;
                }
            } while (key != 0);

        }

        //Square method
        static void SquareValue(ref double side)
        {
            do
            {
                Console.Write("Tərəf daxil edin: ");
                side = Convert.ToInt32(Console.ReadLine());
                if (side <= 0) Console.WriteLine("Yanlış məlumat daxil edildi");
            }
            while (side <= 0);
        }

        //Rectangular method
        static void RectangularValue(ref double width, ref double length)
        {
            do
            {
                Console.Write("Enini daxil edin: ");
                width = Convert.ToInt32(Console.ReadLine());
                if (width <= 0) Console.WriteLine("Yanlış məlumat daxil edildi");
            }
            while (width <= 0);
            do
            {
                Console.Write("Uzunluğunu daxil edin: ");
                length = Convert.ToInt32(Console.ReadLine());
                if (length <= 0) Console.WriteLine("Yanlış məlumat daxil edildi");
            }
            while (length <= 0);
        }
    }
}
