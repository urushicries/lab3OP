using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlibrarylab8
{
    // Абстрактный класс
    public abstract class Shape
    {
        // Абстрактный метод для вычисления площади
        public abstract double Area();

        // Переопределение метода ToString базового класса Object
        public override string ToString()
        {
            return $"Тип: {this.GetType().Name}, Площадь: {Area():F2}";
        }
    }

    // Класс для круга, наследующий абстрактный класс Shape
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Реализация абстрактного метода Area для круга
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Класс для прямоугольника, наследующий абстрактный класс Shape
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Реализация абстрактного метода Area для прямоугольника
        public override double Area()
        {
            return Width * Height;
        }
    }
}