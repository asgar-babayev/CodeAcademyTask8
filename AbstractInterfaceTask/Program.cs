using AbstractInterfaceTask.Models;
using System;

namespace AbstractInterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangular rectangular = new Rectangular(1, 1);
            Square square = new Square(1);
            int key;
            do
            {
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Kvadratın sahəsinin tapılmas...");
                        do
                        {
                            Console.Write("Tərəf daxil edin: ");
                            square.Side = Convert.ToInt32(Console.ReadLine());
                            if (square.Side <= 0) Console.WriteLine("Yanlış məlumat daxil edildi");
                        }
                        while (square.Side <= 0);
                        Console.WriteLine($"Tərəfi {square.Side} olan kvadratın sahəsi = {square.CalcArea()}");
                        Console.WriteLine("---------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Düzbucaqlının sahəsini tapılması...");
                        do
                        {
                            Console.Write("Enini daxil edin: ");
                            rectangular.Width = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Uzunluğunu daxil edin: ");
                            rectangular.Length = Convert.ToInt32(Console.ReadLine());
                            if (rectangular.Width <= 0 || rectangular.Length <= 0) Console.WriteLine("Yanlış məlumat daxil edildi");
                        } 
                        while (rectangular.Width <= 0 && rectangular.Length <= 0);
                        Console.WriteLine($"Eni {rectangular.Width} uzunluğu {rectangular.Length} olan düzbucaqlının sahəsi = {rectangular.CalcArea()}");
                        Console.WriteLine("---------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Yanlış məlumat daxil edildi");
                        break;
                }
            } while (key != 0);

        }
    }
}
