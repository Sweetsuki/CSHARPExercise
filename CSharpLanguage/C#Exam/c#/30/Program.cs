using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("输入学生姓名：");
                string name=Console.ReadLine();
                if(name=="")
                {
                   throw new ArgumentNullException();
                }
                Console.Write("输入年龄：");
                int age = int.Parse(Console.ReadLine());
                if(age>45||age<15)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.Write("输入邮箱地址：");
                string email=Console.ReadLine();
                if(!email.Contains('@'))
                {
                    throw new FormatException();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("姓名不能为空");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("年龄不在15-45之间");
            }
            catch (FormatException)
            {
                Console.WriteLine("email字符串必须包含@");
            }
        }
    }
}
