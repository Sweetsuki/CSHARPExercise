using System;
namespace P1301
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int count = 0;
            int result;
            int[] s = new int[4];
            while (flag)
            {
                Console.Write("除数：");
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    result = 100 / a;
                    for (int i = 0; i <5; i++)
                        s[i] = result;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("分母不为0");
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入的格式不正确！");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("咦，超出范围了！");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("数据溢出");
                }
                finally
                {
                    Console.WriteLine("一共计算了{0}次", ++count);
                    if (count > 4)
                        flag = false;
                }
            }
        }
    }
}