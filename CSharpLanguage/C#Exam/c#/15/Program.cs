using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        class Teacher
        {
            private string teaNo;
            private string teaName;
            private string teaBirth;
            public string TeaNo
            {
                get { return teaNo; }
                set {teaNo = value ; }
            }
            public string TeaName
            {
                get { return teaName; }
                set {teaName = value ; }
            }
            public string TeaBirth
            {
                get { return teaBirth; }
                set {teaBirth = value ; }
            }
            public void InputInformation()
            {
                Console.Write("请输入工号：");
                teaNo = Console.ReadLine();
                Console.Write("请输入姓名：");
                teaName = Console.ReadLine();
                Console.Write("请输入生日:");
                teaBirth = Console.ReadLine();            
            }
            public void ShowInformation()
            {
                DateTime dateTime = DateTime.Parse(teaBirth);
                Console.WriteLine("工号：{0}，姓名：{1}，生日{2}", teaNo, teaName,dateTime );
            }
        }
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.InputInformation();
            t.ShowInformation();
            Console.ReadKey();
        }
    }
}
