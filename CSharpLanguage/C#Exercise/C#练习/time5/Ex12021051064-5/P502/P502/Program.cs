using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace P502
{
    class Student
    {
        public string stuNo;
        public string StuNO
        {
            get { return stuNo; }
            set { stuNo = value; }
        }
        public string stuName;
        public string StuNAME
        {
            get { return stuName; }
            set { stuName = value; }
        }
        public int nianLing;
        public int NianLing
        {
            get { return nianLing; }
            set { nianLing = value; }
        }
        public double chineseScore;
        public double ChineseScore
        { 
            get { return chineseScore; }
            set { chineseScore = value; }
        }
        public double mathsScore;
        public double MathScore
        {
            get { return mathsScore; }
            set { mathsScore = value; }
        }
        public Student()
        {
            stuNo = "16";
            stuName = "张三";
            nianLing= 20;
            chineseScore = 85;
            mathsScore = 90;
            Console.WriteLine("提示信息：无参数构造函数");
        }
        public Student(string StuNo, string StuName)
        {
            stuNo = StuNo;
            stuName = StuName;
            do
            {   
                Console.WriteLine("请输入年龄：");
                nianLing = int.Parse(Console.ReadLine()); 
            }while (nianLing < 18 || nianLing > 30);
            do
            {
                Console.WriteLine("请输入语文成绩：");
                chineseScore = double.Parse(Console.ReadLine());
            } while (chineseScore <0 || chineseScore >100);
            do 
            {
                Console.WriteLine("请输入数学成绩：");
                mathsScore = double.Parse(Console.ReadLine());
            }while(mathsScore < 0 ||  mathsScore > 100);
        }
        public void Print()
        {
            Console.Write("学号：{0}，", stuNo);
            Console.Write("姓名：{0}，", stuName);
            Console.Write("语文：{0:f2}，", chineseScore);
            Console.Write("数学：{0:f2}，", mathsScore);
            Console.WriteLine("总分：{0:f2}", chineseScore + mathsScore);
        }
        ~Student()
        {
            Console.WriteLine("学生对象已摧毁");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            Student S2 = new Student("64", "Jason");
            S1.Print();
            S2.Print();
            Console.ReadKey();
        }
    }
}