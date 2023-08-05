using System;
namespace app6
{
    class MyClass1
    {
        public virtual void ShowInfo()
        {
            Console.WriteLine();
        }
    }
    sealed class MyClass2 : MyClass1
    {
        public string id;
        public string name;
        public sealed override void ShowInfo()
        {
            Console.WriteLine("用户编号：{0}，名称：{1}", id, name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();
            myclass1.ShowInfo();
            MyClass2 myclass2 = new MyClass2();
            myclass2.id = "A001";
            myclass2.name = "TM";
            myclass2.ShowInfo();
        }
    }
}