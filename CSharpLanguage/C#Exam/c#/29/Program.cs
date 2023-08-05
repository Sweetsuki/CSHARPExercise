using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                Console.Write("输入第一个数a：");
                int a = int.Parse(Console.ReadLine());
                Console.Write("输入数第二个数b：");
                int b = int.Parse(Console.ReadLine());
                double c = a / b;
                Console.WriteLine("{0}除以{1}等于{2}", a, b, c);
            }
            catch(FormatException)
            {
                Console.WriteLine("输入值格式不对");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("除数不能为0");
            }
        }
    }
}
