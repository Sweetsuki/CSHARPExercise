using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace P501
{
    class Teacher
    {
        private string teaNo;
        private string teaName;
        private int teaAge;
        private static string schoolName = "三江学院";
        private static int totalNum = 0;
        public Teacher()
        {
            teaNo = "12";
            teaName = "Jane";
            teaAge = 20;
            totalNum++;
        }
        public Teacher(string TeaName)
        {
            teaNo = "20";
            teaName = TeaName;
            teaAge = 36;
            totalNum++;
        }
        public Teacher(string TeaNo, string TeaName, int TeaAge)
        {
            teaNo = TeaNo;
            teaName = TeaName;
            teaAge = TeaAge;
            totalNum++;
        }
        public static void SetSchool(string NewName)
        {
            schoolName = NewName;
        }
        public void ShowInfo()
        {
            Console.WriteLine("工号：{0}",teaNo);
            Console.WriteLine("姓名：{0}",teaName);
            Console.WriteLine("年龄：{0}",teaAge);
            Console.WriteLine(Teacher.schoolName);
            Console.WriteLine("{0}", totalNum);
        }
        ~Teacher()
        {
            Console.WriteLine("老师对象摧毁");
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {   
            Teacher.SetSchool("南京大学");
            Teacher T1 = new Teacher();
            T1.ShowInfo();
            Teacher T2 = new Teacher("张三");
            T2.ShowInfo();
            Teacher T3 = new Teacher("64", "Jason", 20);
            T3.ShowInfo();
            Console.ReadKey();
        }
    }
}