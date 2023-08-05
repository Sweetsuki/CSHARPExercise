using System;
namespace Exercise23
{
    abstract class Shape
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double GetArea();
    }
    class Circle:Shape
    {
        private double r;
        public Circle(double r):base("圆")
        { 
            this.r = r;
        }
        public override double GetArea()
        {
            Console.WriteLine("图形名称："+Name);
            return r*r*Math.PI;
        }
    }
    class Rectangle:Shape
    {
        private double l;//长
        private double w;//宽
        public Rectangle(double l, double w):base("长方形")
        {
            this.l = l;
            this.w = w;
        }
        public override double GetArea()
        {
            Console.WriteLine("图形名称："+Name);
            return l*w;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(2.0);
            Console.WriteLine("图形面积值："+shape.GetArea());
            shape = new Rectangle(2.0,3.0);
            Console.WriteLine("图形面积值：" + shape.GetArea());
        }
    }
}