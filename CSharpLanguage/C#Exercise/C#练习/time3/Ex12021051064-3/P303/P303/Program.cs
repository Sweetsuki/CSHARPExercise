using System;
namespace P303
{
    class Program1
    {
        static void Main()
        {
            int sum = 0, average =0, max =0;
            Console.Write("请输入班级人数：");
            int number = int.Parse(Console.ReadLine());
            int[]num = new int[number];
            for(int i = 0;i<number ;i++ )
            {
                Console.Write("请输入第{0}个人的年龄：",i+1);
                int old = int.Parse(Console.ReadLine());
                num[i] = old;
                if(max < num[i] ) 
                    max = num[i];
                sum += old;
            }
            average = sum / number;
            Console.WriteLine("年龄总和为：{0}",sum);
            Console.WriteLine("平均年龄为：{0}",average);
            Console.WriteLine("最大年龄是：{0}\n",max);
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();
            
        }
    }
}
