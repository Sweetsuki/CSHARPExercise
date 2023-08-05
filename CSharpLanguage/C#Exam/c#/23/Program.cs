using System;

namespace _23
{
    internal class Program
    {
        abstract  class Shape
        {
            private string name;
            public string Name
            {
                get { return name; }
            }
            public Shape() { }
            public Shape(string name)
            {
                this.name = name;
            }
            public abstract double Area();
        }
        class Circle:Shape
        {
            private double r;
            public Circle(string name,double r):base(name)
            {
                this.r = r;
            }
            public override double Area()
            {
                double PI = Math.PI;
                return r*r*PI;
            }
        }
        class Rectangle : Shape
        {
            private double l;
            private double w;
            public Rectangle(string name,double l,double w):base(name)
            {
                this.l = l;
                this.w = w;
            }
            public override double Area()
            {
                return l*w;
            }
        }
        static void Main(string[] args)
        {
            Shape circle = new Circle("圆",3);
            Console.WriteLine("图形名称：{0}，面积：{1:f2}", circle.Name, circle.Area());
            Shape rectangle = new Rectangle("长方形",4,5);
            Console.WriteLine("图形名称：{0}，面积：{1}", rectangle.Name, rectangle.Area());


        }
    }
}
