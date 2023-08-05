using System;
namespace P1102
{
    abstract class Sharp
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    class Cirlce : Sharp
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public Cirlce(double r)
        {
            this.r = r;
        }
        public override double GetArea()
        {
            return Math.PI * r * r;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * r;
        }
    }
    class Rectangle : Sharp
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { Width = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sharp sharp1 = new Cirlce(3.2);
            Console.WriteLine("周长是{0:F2},面积是{1:F2}", sharp1.GetPerimeter(), sharp1.GetArea());
            Sharp sharp2 = new Rectangle(3.2, 4.5);
            Console.WriteLine("周长是{0:F2},面积是{1:F2}", sharp2.GetPerimeter(), sharp2.GetArea());
        }
    }
}