using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        class Teacher
        {
            private string teaNo;
            private string teaName;
            private int teaAge;
            private string teaTitle;
            public string TeaNo
            {
                get { return teaNo; }
                set { teaNo = value; }
            }
            public string TeaName
            {
                get { return teaName; }
                set { teaName = value; }
            }
            public int TeaAge
            {
                get { return teaAge; }
                set { teaAge = value; }
            }
            public string TeaTitle
            {
                get { return teaTitle; }
                set { teaTitle = value; }
            }
            public Teacher(string teaNo,string teaName,int teaAge,string teaTitle)
            {
                this.teaNo = teaNo;
                this.teaName = teaName;
                this.teaAge = teaAge;
                this.teaTitle = teaTitle;
            }
            public void Show()
            {
                Console.WriteLine("工号：{0}，姓名：{1}，年龄：{2}，职称：{3}",teaNo,teaName,teaAge,teaTitle);
            }
        }
        class PartTimeTeacher:Teacher
        {
            private string originalSchool;
            public string OriginalSchool
            {
                get { return originalSchool; }
                set { originalSchool = value; }
            }
            public PartTimeTeacher(string teaNo,string teaName,int teaAge,string teaTitle, string originalSchool):base(teaNo,teaName,teaAge,teaTitle)
            {
                this.originalSchool = originalSchool;
               
            }
            public new void Show()
            {
                Console.WriteLine("兼职教师信息：");
                base.Show();
                Console.WriteLine("原单位名称：{0} ", originalSchool);
            }
        }
        static void Main(string[] args)
        {
            Teacher t = new Teacher("001", "aa", 40,"校长");
            PartTimeTeacher Mike = new PartTimeTeacher("002","bb",30,"教授","南京大学");
            t.Show();
            Mike.Show();
        }
    }
}
