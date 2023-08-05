//class Student : Exception
//{
//    private string name;
//    public string Name
//    {
//        get { return name; }
//        set { value = name; }
//    }
//    private string birth;
//    public string Birth
//    {
//        get { return birth; }
//        set { value = birth; }
//    }
//    public Student(string name, string birth, string str)
//    {
//        this.name = name;
//        this.birth = birth;
//        if (name == null)
//        {
//            throw new ArgumentNullException();
//        }
//        int now = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
//        int date = now - int.Parse(birth);
//        int age = date / 10000;
//        if (age < 18 || age > 45)
//        {
//            throw new ArgumentOutOfRangeException();
//        }
//        if (str.IndexOf("@") == -1)
//        {
//            throw new FormatException();
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {

//            Student s1 = new Student("小圆", "19120208", "abc@163.com");

//        }

//        catch (ArgumentNullException)
//        {
//            Console.WriteLine("姓名不能为空");
//        }
//        catch (ArgumentOutOfRangeException)
//        {
//            Console.WriteLine("年龄不在范围之内");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("输入格式错误");
//        }
//        finally
//        {
//            Console.Write("输入email地址");
//            string str = Console.ReadLine();//"abc@163.com"
//            int index = str.IndexOf("@");
//            string name = str.Substring(0, index);
//            int dotIndex = str.IndexOf(".");
//            string domain = str.Substring(index + 1, dotIndex - index);
//            Console.WriteLine(name);
//            Console.WriteLine(domain);
//        }
//    }
//}
using _01302;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01302
{
    class Student : Exception
    {
        public Student(string a) : base(a)
        {
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        int q = 3;
        double[] a = new double[q];
        while (flag == true)
        {
            try
            {
                Console.WriteLine("请输入{0}位学生的成绩。", a.Length);
                for (int i = 0; i < q; i++)
                {
                    a[i] = Convert.ToDouble(Console.ReadLine());
                    if (a[i] < 0 || a[i] > 100)
                        throw new Student(string.Format("输入的分数不是0-100之间"));
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
            catch (Student e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (Console.ReadLine().ToUpper() == "QUIT")
                {
                    flag = false;
                }
            }



        }
    }
    }