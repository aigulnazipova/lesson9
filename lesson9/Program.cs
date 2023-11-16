using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1. Программа реализует методы поддержки шифрования строк.\n");
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();

            string original = "В";
            string encodedACipher = aCipher.Encode(original);
            string encodedBCipher = bCipher.Encode(original);

            Console.WriteLine($"Оригинальный текст: {original}");
            Console.WriteLine($"ACipher: {encodedACipher}");
            Console.WriteLine($"ACipher дешифровка: {aCipher.Decode(encodedACipher)}");
            Console.WriteLine($"BCipher: {encodedBCipher}");
            Console.WriteLine($"BCipher дешифровка: {bCipher.Decode(encodedBCipher)}\n");

            Console.WriteLine("Нажмите Enter для прехода к следующему заданию\n");
            Console.ReadKey();

            
            
            Console.WriteLine("Д/з 10.1\n");
            Point point = new Point("Красный", true, 5, 15);
            point.PrintInfo();
            point.IsVisible(false);
            point.MoveY(10);
            point.SetColor("Зеленый");
            point.PrintInfo();

            Circle circle = new Circle("Синий", true, 7, 21, 9);
            circle.PrintInfo();
            double circleArea = circle.CalculateArea();
            Console.WriteLine($"Площадь окружности: {circleArea}");

            Rectangle rectangle = new Rectangle("Желтый", true, 8, 13, 14, 7);
            rectangle.PrintInfo();
            double rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"Площадь прямоугольника: {rectangleArea}");
            
            Console.ReadKey();



        }
    }
}
