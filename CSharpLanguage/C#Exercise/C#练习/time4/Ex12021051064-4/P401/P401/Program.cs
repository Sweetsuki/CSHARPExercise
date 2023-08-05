using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P401
{
    class Program
    {
        class Student
        {
            public string stuNo;
            public string stuName;
            public string stuSex;
            public DateTime stuBirthtime;
            public struct Native
            {
                public string Province;
                public string City;
            }
            public Native Native1;
            public void Print()
            {
                Console.WriteLine("学号：{0}，姓名{1},性别{2}，出生年月{3}", stuNo, stuName, stuSex, stuBirthtime);
                Console.WriteLine("{0}省{1}市", Native1.Province, Native1.City);
            }
        }
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.stuNo = "12021051064";
            S1.stuName = "华心童";
            S1.stuSex = "男";
            S1.stuBirthtime = new DateTime(2003, 8, 8);
            S1.Native1.Province = "江苏";
            S1.Native1.City = "南京";
            S1.Print();
            Student S2 = S1;
            S2.Print();
            Console.ReadKey();

        }
    }
}