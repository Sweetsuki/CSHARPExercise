using System;
namespace ConsoleApplication1
{
    interface Ia
    {
        float GetArea();
    }
    interface Ib
    {
        float GetLength();
    }
    class Rectangle : Ia, Ib
    {
        private float x;
        private float y;
        public Rectangle(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetArea()
        {
            return x * y;
        }
        float Ib.GetLength()
        {
            return 2 * (x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2.5f, 3.0f);
            Console.WriteLine("长方形的面积为：" + r1.GetArea());
            Ia box1 = r1;
            Console.WriteLine("长方形的面积为：" + box1.GetArea());
            Ib box2 = new Rectangle(2.5f, 3.0f);
            Console.WriteLine("长方形的周长是：" + box2.GetLength());
            Console.ReadKey();
        }
    }
}