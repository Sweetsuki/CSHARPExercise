using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        class Teacher
        {
            private string teaNo;
            private string teaName;
            private int teaAge;
            static string schoolName = "";
            static int totalNum = 0;
            public Teacher() { }
            public Teacher(string TeaName)
            {
                this.teaName = TeaName;
                Teacher.totalNum++;
            }
            public Teacher(string TeaNo, string TeaName, int TeaAge)
            {
                teaNo = TeaNo;
                teaName = TeaName;
                teaAge = TeaAge;
                totalNum++;
            }
            public void SetSchool(string newname)
            {
                schoolName = newname;
            }
            public void ShowInfo()
            {
                Console.WriteLine("工号：{0}，姓名：{1}，年龄：{2}，学校名称：{3}", teaNo, teaName, teaAge, schoolName);
                Console.WriteLine("老师共有：{0}",totalNum);
            }

            static void Main(string[] args)
            {
                Teacher t1 = new Teacher("001", "小王", 40);
                t1.SetSchool("南京大学");
                t1.ShowInfo();
                Teacher t2 = new Teacher("001", "老张", 40);
                t2.SetSchool("东南大学");
                t2.ShowInfo();
            }
        }
    }
}
