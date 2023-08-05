using System;
using System.Security.Principal;

namespace Exercise14
{
    
    class Program
    {
        public static int GetAgeByBirthdate(DateTime birthdate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthdate.Year;
            if (now.Month < birthdate.Month || (now.Month == birthdate.Month && now.Day < birthdate.Day))
            {
                age--;
            }
            return age < 0 ? 0 : age;
        }
        static void Main(string[] args)
        {
            //DateTime dt1 = new DateTime(2003,8,8);
            //Console.WriteLine(GetAgeByBirthdate(dt1));
            Console.Write("输入：");
            string identity = Console.ReadLine();
            string birth = identity.Substring(6, 8);
            string sex = identity.Substring(16, 1);
            IFormatProvider format = new System.Globalization.CultureInfo("zh-CN");
            string TarStr = "yyyyMMdd";
            DateTime birthday = DateTime.ParseExact(birth, TarStr, format);
            Console.Write(string.Format("输出：{0:yyyy年MM月dd日}", birthday));
            if (int.Parse(sex) % 2 == 0)
            {
                sex = "女";
            }
            else
            {
                sex = "男";
            }
            //int old = DateTime.Now.Year - int.Parse(identity.Substring(6, 4));
            Console.WriteLine(",今年" + GetAgeByBirthdate(birthday) + "岁。" + "性别：" + sex);
        }
    }
}
