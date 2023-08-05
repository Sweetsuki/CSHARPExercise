using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1002
{
    class Rectangle
    {
        public const double PI = Math.PI;
        protected double x;
        protected double y;
        public Rectangle() { }
        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double Area()
        {
            double area = x * y;
            return area;
        }
    }
    class circle : Rectangle
    {
        public circle(double r) : base(r, 0)
        {
            this.x= r;
        }
        public override double Area()
        {
            double area = x * x * PI;
            return area;
        }
    }
    class Sphere : Rectangle
    {
        public Sphere(double r) : base(r, 0)
        {
            this.x= r;
        }
        public override double Area()
        {
            double area = 4 * PI * x * x;
            return area;
        }
    }
    class Cylindar : Rectangle
    {
        public Cylindar(double a, double b) : base(a, b)
        {
            this.x = a;
            this.y = b;
        }
        public override double Area()
        {
            double area = 2 * PI * x * x + 2 * PI * x * y;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.6, y = 8.0;
            Rectangle t = new Rectangle(x, y);
            Rectangle c = new circle(x);
            Rectangle s = new Sphere(x);
            Rectangle l = new Cylindar(x, y);
            Console.WriteLine("长为{0}，宽为{1}的长方形面积={2:F2}", x, y, t.Area());
            Console.WriteLine("半径为{0}的圆面积={1:F2}", x, c.Area());
            Console.WriteLine("半径为{0}的圆球体表面积={1:F2}", x, s.Area());
            Console.WriteLine("半径为{0},高度为{1}的圆柱体表面积={2:F2}", x, y, l.Area());
            Console.ReadKey();
        }
    }
}