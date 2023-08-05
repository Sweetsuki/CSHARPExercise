using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        class MyClass1
        {
            public virtual void ShowInfo() {}
        }
        class MyClass2:MyClass1
        {
            public string id;
            public string name;
            public sealed override void ShowInfo() 
            {
                Console.WriteLine("用户编号：{0}，名称：{1}", id, name);
            }
        }
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();
            myclass1.ShowInfo();
            MyClass2 myclass2 = new MyClass2();
            myclass2.id = "BM10001";
            myclass2.name = "TM";
            myclass2.ShowInfo();
        }
    }
}
