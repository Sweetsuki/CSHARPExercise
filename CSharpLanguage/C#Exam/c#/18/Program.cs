using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    internal class Program
    {
        class MyPoint
        {
            private int x;
            private int y;
            public int PX
            {
                get { return x; }
                set { value = x; }
            }
            public int PY
            {
                get { return y; }
                set { value = y; }
            }
            public MyPoint() 
            {
                x = 0;
                y = 0;
            }
            public MyPoint(int x, int y) 
            {
                this.x = x;
                this.y = y;
            }
            public void ShowPoint()
            {
                Console.WriteLine("点的坐标为({0},{1})", x, y);
            }
            public double  Disp()
            {
                return Math.Sqrt(x*x+y*y);
            }
            public double Disp(MyPoint p)
            {
                return Math.Sqrt(Math.Pow(x - p.x,2) + Math.Pow(y - p.x,2));
                
            }
           
        }
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint(2,2);
           Console.WriteLine("p1坐标到原点距离为：{0}",p1.Disp());
            MyPoint p2 = new MyPoint(4, 2);
            Console.WriteLine("p1坐标到p2坐标的距离为：{0}", p1.Disp(p2));
            
        }
    }
}
