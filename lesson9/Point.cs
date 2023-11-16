using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal class Point : Figure
    {
        protected int x;
        protected int y;
        /// <summary>
        /// Данный конструктор вызывает конструктор базового класса, передавая ему значения color, visible, x и y.
        /// </summary>
        public Point(string color, bool visible, int x, int y)
            : base(color, visible)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Данный метод переопределяет метод SetColor базового класса.
        /// </summary>
        public override void SetColor(string color)
        {
            this.color = color;
        }
        /// <summary>
        /// Данный метод переопределяет метод IsVisible базового класса.
        /// </summary>
        public override void IsVisible(bool visible)
        {
            this.visible = visible;
        }

        /// <summary>
        /// Данный метод переопределяет метод MoveX базового класса.
        /// </summary>
        public override void MoveX(int dx)
        {
            x += dx;
        }

        /// <summary>
        /// Данный метод переопределяет метод MoveY базового класса.
        /// </summary>
        public override void MoveY(int dy)
        {
            y += dy;
        }

        /// <summary>
        /// Данный метод переопределяет метод Print базового класса.
        /// </summary>
        public override void PrintInfo()
        {
            Console.WriteLine($"Точка:\nЦвет: {color}\nВидимость: {visible}\nКоординаты: {x}, {y}");
        }
    }
}
