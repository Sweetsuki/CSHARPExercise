using System;
namespace P1303
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string birth;
        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Student ()
        {

        }
        public void Show()
        {
            Console.Write("输入学生姓名：");
            string str = Console.ReadLine();
            Console.Write("输入学生的出生日期：");
            string birth = Console.ReadLine();
            Console.Write("输入学生的email地址：");
            string email = Console.ReadLine();
            int index = email.IndexOf("@");
            string name = str.Substring(0, str.Length);
            int old;
            DateTime dt1 = DateTime.Now;
            string year = (birth.Substring(0, 8));
            IFormatProvider format = new System.Globalization.CultureInfo("zh-CN");
            string TarStr = "yyyyMMdd";
            DateTime dt2 = DateTime.ParseExact(year, TarStr, format);
            birth = string.Format("该客户出生日期：{0:yyyy年MM月dd日}", dt2);
            Console.WriteLine(birth);
            old = dt1.Year - dt2.Year;
            Console.WriteLine("学生的姓名：{0},年龄：{1},学生的邮箱：{2}", name, old, email);
            int lastindex = email.IndexOf("@");
            int dotIndex = email.IndexOf('.');
            int dotLastIndex = email.IndexOf('.');
            string domain = email.Substring(index, dotIndex - index);
            if (name==null||name.Length == 0) 
                throw new ArgumentNullException("姓名不能为空串");
            if (old < 18 || old > 45)
                throw new ArgumentOutOfRangeException("异常：年龄必须在18-45之间");
            if (index == -1 || index == 0 || lastindex == email.Length - 1 || lastindex != index || dotIndex == -1 || dotIndex != dotLastIndex || dotIndex == 0 || dotLastIndex == email.Length - 1)
            {
                throw new FormatException(String.Format("这不是正确的Email地址"));
            }
            else Console.WriteLine(domain);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student();
                s1.Show();
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
            try
            {
                Student s2 = new Student();
                s2.Show();
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
            try
            {
                Student s3 = new Student();
                s3.Show();
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
            try
            {
                Student s4 = new Student();
                s4.Show();
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