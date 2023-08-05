using System;
namespace P702
{
    public class area
    {
        public const double PI = 3.1415927;
        public double a;
        public double b;
        public double c;
        //public string d;
        public double Area(double r, string s)
        {
            if (s == "圆")
            {
                return PI * r * r;
            }
            else if (s == "正方形")
            {
                return r * r;
            }
            else if (r != Convert.ToDouble(s))
            {
                return r*Convert.ToDouble(s);
            }
            else
                return 0;
        }
        public double Area(double x, double y, string z)
        {
            this.a = x;
            this.b = y;
            if (z == "长方形")
                return this.a * this.b;
            else if(z=="圆柱体") 
            { return 2 * PI * this.a * (this.a + this.b); }
            return 0;
        }
        public double Area(double x, double y, double z)
        {
            this.a = x;
            this.b = y;
            this.c = z;
            return (this.a + this.b) * this.c / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            area r = new area();
            Console.WriteLine("半径为8的圆面积：" + r.Area(8, "圆"));
            Console.WriteLine("边长为8的正方形面积：" + r.Area(8, "正方形"));
            Console.WriteLine("边长9和13的长方形面积：" + r.Area(9,"13"));
            Console.WriteLine("上底3，下底4，高为5的梯形面积：" + r.Area(3, 4, 5));
            Console.WriteLine("半径为2，高为4的圆柱体面积："+r.Area(2,4,"圆柱体"));
            Console.ReadKey();
        }
    }
}
//using System;
//namespace HelloWorldApplication
//{
//    class area
//    {
//        public const double p = 3.1415926;
//        public double Area(int a, string b)
//        {
//            //错误返回0
//            if (b == "圆")
//                return a * a * p;
//            if (b == "正方形")
//                return a * a;
//            else
//                return 0;
//        }
//        public double Area(int a, params int[] b)
//        {

//            if (b.Length == 1)
//                return a * b[0];
//            else
//                return (a + b[0]) * b[1] / 2.0;
//        }
//        public double Area(int a, int b, string c)
//        {
//            if (c == "长方形")
//                return a * b;
//            if (c == "圆柱体")
//                return (2 * a * a * p) + (2 * p * a * b);
//            else return 0;
//        }
//    }
//    class HelloWorld
//    {

//        static void Main(string[] args)
//        {
//            area r = new area();
//            Console.WriteLine("半径为5的圆面积:" + r.Area(5, "圆"));
//            Console.WriteLine("边长为5的正方形面积:" + r.Area(5, "正方形"));
//            Console.WriteLine("半径为5的圆面积:" + r.Area(5, "只因"));
//            Console.WriteLine("边长为5和4的长方形面积:" + r.Area(5, 4));
//            Console.WriteLine("上底3，下底4，高为5的梯形面积:" + r.Area(3, 4, 5));
//            Console.WriteLine("长为3，宽为4的长方形的面积为:" + r.Area(3, 4, "长方形"));
//            Console.WriteLine("半径为3，高为4的圆柱体体积为" + r.Area(3, 4, "圆柱体"));
//        }
//    }
//}

