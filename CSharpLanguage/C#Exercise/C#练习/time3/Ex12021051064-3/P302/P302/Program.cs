using System;
namespace P302
{
    class Program1
    {
        static void Main()
        {
            double p, s=0;
            Console.Write("请输入三角形的三边（用空格分开）："); 
            string value  = Console.ReadLine();
            string[] vals = value.Split(' ');
            int[] num1= new int[3];
            num1[0] = int.Parse(vals[0]);
            num1[1] = int.Parse(vals[1]);
            num1[2] = int.Parse(vals[2]);
            p = (num1[0] + num1[1] + num1[2]) / 2.0;
            s = Math.Sqrt(p * (p - num1[0]) * (p - num1[2]) * (p - num1[1]));
            if(num1[0]+num1[1]>num1[2]&&num1[0]+num1[2]>num1[1] && num1[2]+num1[1]>num1[0])
            {  
                    p = (num1[0] + num1[1] + num1[2]) / 2.0;
                    s = Math.Sqrt(p * (p - num1[0]) * (p - num1[2]) * (p - num1[1]));
                    Console.WriteLine("三角形的面积是：{0:F2}",s);
                    Console.Write("请按任意键继续...");
                    Console.ReadKey();
            }
            else{ 
                for (int i = 0; num1[0] + num1[1]<=num1[2] ||num1[0] + num1[2] <= num1[1] ||num1[2] + num1[1] <=num1[0]; i++)
                { 
                    Console.Write("输入的不是三角形，请重新输入三边（用空格分开）：");
                    value = Console.ReadLine();
                    vals = value.Split(' ');
                    num1[0] = int.Parse(vals[0]);
                    num1[1] = int.Parse(vals[1]);
                    num1[2] = int.Parse(vals[2]);
                }
                p = (num1[0] + num1[1] + num1[2]) / 2.0;
                s = Math.Sqrt(p * (p - num1[0]) * (p - num1[2]) * (p - num1[1]));
                Console.WriteLine("三角形的面积是：{0:F2}", s);
                Console.Write("请按任意键继续...");
                Console.ReadKey();
            }
        }
    }
}
