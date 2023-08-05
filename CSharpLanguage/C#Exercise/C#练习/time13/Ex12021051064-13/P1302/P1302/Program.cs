using System;
namespace P1302
{
    class MyException:Exception
    { 
        public MyException(string message) : base(message)
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] c1 = new double[4];
            double sum = 0;
            double avgscore;
            int count = 0;
            bool flag = true;
            int correct=0;
            while (flag) 
            {
                try
                {
                    Console.Write("请输入{0}名同学的成绩：", c1.Length);
                    for (int i = 0; i < 5; i++)
                    {
                        c1[i] = double.Parse(Console.ReadLine());
                        correct++;
                        if (c1[i] >= 0 && c1[i] <= 100)
                            count++;
                        if (c1[i] < 0 || c1[i]>100)
                            throw new MyException(string.Format("输入的分数不是0-100之间"));
                        sum += c1[i];
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入的格式不正确！");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("数组超出范围了！");
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sum > 0)
                    {
                        avgscore = sum / count;
                        Console.WriteLine("输入总数：{0}，正确的个数：{1}，总分：{2}，平均分：{3:F2}", correct, count, sum, avgscore);
                        sum = 0; correct = 0; count = 0;
                    }
                    if(Console.ReadLine().ToUpper()=="QUIT")
                        flag = false;
                }
            }
            
        }
    }
}