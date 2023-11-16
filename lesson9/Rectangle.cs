using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Rectangle : Point, ICalculateArea
    {
        private double a;
        private double b;

        /// <summary>
        /// Данный конструктор вызывает конструктор базового класса, передавая ему значения color, visible, x и y.
        /// </summary>
        public Rectangle(string color, bool visible, int x, int y, double a, double b)
            : base(color, visible, x, y)
        {
            this.a = a;
        }

        /// <summary>
        /// Данный метод переопределяет метод Print базового класса.
        /// </summary>
        public override void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник:\nЦвет: {color}\nВидимость: {visible}\nКоординаты: {x}, {y}\n");
        }

        /// <summary>
        /// Данный метод переопределяет метод интерфейса ICalculateArea.
        /// </summary>
        public double CalculateArea()
        {
            return a * b;
        }
    }
}
