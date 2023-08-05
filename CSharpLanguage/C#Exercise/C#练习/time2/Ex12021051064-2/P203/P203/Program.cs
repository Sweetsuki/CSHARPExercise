using System;
namespace P203
{
    class Program
    {
        static void Main()
        {
            double p, s;
            Console.Write("请输入三角形的第一条边：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("请输入三角形的第二条边：");
            int b = int.Parse(Console.ReadLine()); 
            Console.Write("请输入三角形的第三条边：");
            int c = int.Parse(Console.ReadLine()); 
            if(a + b > c && a + c > b && b + c > a) 
            { 
                p = (a + b + c) / 2.0;
                s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                Console.WriteLine("边长a={0}，b={1}，c={2}的三角形面积为：{3:F2}", a, b, c, s);
            }
            else { 
                Console.WriteLine("({0}，{1}，{2})三条边不能构成三角形！",a,b,c); 
            }
            Console.ReadKey();
        }
    }
}