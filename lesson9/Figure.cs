using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    internal abstract class Figure
    {
        protected string color;
        protected bool visible;

        public Figure(string color, bool visible)
        {
            this.color = color;
            this.visible = visible;
        }

        /// <summary>
        /// Метод для передвижения объекта по горизонтали.
        /// </summary>
        public abstract void MoveX(int dx);
        /// <summary>
        /// Метод для передвижения объекта по вертикали.
        /// </summary>
        public abstract void MoveY(int dy);
        public abstract void SetColor(string color);
        public abstract void  IsVisible(bool visible);
        /// <summary>
        /// Метод для вывода информации об объекте класса на консоль.
        /// </summary>
        public abstract void PrintInfo();

    }
}
