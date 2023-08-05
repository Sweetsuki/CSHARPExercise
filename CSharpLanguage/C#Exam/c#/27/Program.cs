using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    internal class Program
    {
        interface Ia    
        {
            float GetArea();
        }
        public class RectangleA : Ia
        {
            float x, y;
            public RectangleA(float x1, float y1)
            {
                x = x1;
                y = y1;
            }
            public float GetArea()
            {
                return x * y;
            }
        }
        public class RectangleB : Ia
        {
            float x, y;
            public RectangleB(float x1, float y1)
            {
                x = x1;
                y = y1;
            }
            public float GetArea()
            {
                return x * y;
            }
        }
        static void Main(string[] args)
        {
            Ia a = new RectangleA(1,2);
            Console.WriteLine("长方形面积是{0}", a.GetArea());
            Ia b= new RectangleB(4, 2);
            Console.WriteLine("长方形面积是{0}", b.GetArea());
        }
    }
}
