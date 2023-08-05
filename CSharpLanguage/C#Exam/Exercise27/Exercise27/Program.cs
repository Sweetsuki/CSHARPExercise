using Exercise27;
using System;
namespace Exercise27
{
    interface Ia //声明接口 Ia
    {
        float getarea(); //接口成员声明
    }

    public class RectangleA : Ia //类 A 继承接口 Ia
    {
        float x, y;
        public RectangleA(float x1, float y1) //构造函数
        {
            x = x1; 
            y = y1;
        }
        //隐式接口成员实现
        public float getarea()
        {
            return x* y;
        }
    }
    public class RectangleB : Ia //类 Rectangle 继承接口 Ia
    {
        float x, y;
        public RectangleB(float x1, float y1) //构造函数
        {
            x = x1;
            y = y1;
        }
        //显式接口成员实现
        float Ia.getarea()
        {
            return x* y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //隐式实现
            RectangleA r1 = new RectangleA(2.5f,3.0f);
            Ia a1 = r1;
            Console.WriteLine("长方形的面积：" + a1.getarea());
            Ia a2 = new RectangleB(2.5f, 4.0f);
            Console.WriteLine("长方形的面积：" + a2.getarea());

        }
    }
}
