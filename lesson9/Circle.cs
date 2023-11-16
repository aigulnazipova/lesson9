using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Circle : Point, ICalculateArea
    {
        private double radius;
        /// <summary>
        /// Данный конструктор вызывает конструктор базового класса, передавая ему значения color, visible, x и y.
        /// </summary>
        public Circle(string color, bool visible, int x, int y, double radius)
            : base(color, visible, x, y)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Данный метод переопределяет метод Print базового класса.
        /// </summary>
        public override void PrintInfo()
        {
            Console.WriteLine($"Круг:\nЦвет: {color}\nВидимость: {visible}\nКоординаты: {x}, {y}\n");
        }

        /// <summary>
        /// Данный метод реализовывает метод интерфейса ICalculateArea.
        /// </summary>
        public double CalculateArea()
        {
            return Math.PI * radius * radius ;
        }
    }
}
