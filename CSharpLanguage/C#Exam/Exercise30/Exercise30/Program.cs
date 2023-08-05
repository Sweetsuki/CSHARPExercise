using System;
namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("输入学生姓名：");
                string name = Console.ReadLine();
                if(name== null||name.Length==0)
                {
                    throw new ArgumentNullException();
                }
                Console.Write("输入学生年龄：");
                int age = int.Parse(Console.ReadLine());
                if(age>45||age<15)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.Write("输入学生eMail地址：");
                string eMail = Console.ReadLine();
                int index =eMail.IndexOf("@");
                int lastindex = eMail.IndexOf("@");
                int dotIndex = eMail.IndexOf('.');
                int dotLastIndex = eMail.IndexOf('.');
                if (index == -1 || index == 0 || lastindex == eMail.Length - 1 || lastindex != index || dotIndex == -1 || dotIndex != dotLastIndex || dotIndex == 0 || dotLastIndex == eMail.Length - 1)
                {
                    throw new FormatException();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Exception：姓名不能为空串");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception：年龄必须要在18-45之间");
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception：这不是正确的Email地址");
            }

        }
    }
}