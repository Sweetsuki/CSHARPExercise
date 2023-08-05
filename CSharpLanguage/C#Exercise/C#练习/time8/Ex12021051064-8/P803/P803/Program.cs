using System;
namespace P803
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入身份证号：");
            string identity = Console.ReadLine();
            string sex;
            if (Convert.ToDouble(identity.Substring(16, 1)) % 2 == 0)
            {
                sex = "女";
            }
            else
            {
                sex = "男";
            }
            string  year = (identity.Substring(6, 8));
            IFormatProvider format = new System.Globalization.CultureInfo("zh-CN");
            string TarStr = "yyyyMMdd"; 
            DateTime date = DateTime.ParseExact(year, TarStr,format);
            identity = string.Format("该客户出生日期：{0:yyyy年MM月dd日}，性别是：{1}", date,sex);
            Console.WriteLine("{0}",identity);
            Console.ReadKey();
        }
    }
}