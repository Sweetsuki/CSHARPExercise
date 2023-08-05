using System;
namespace ConsoleApplication3
{
    class MyClass1
    {
        public virtual void ShowInfo()
        {
        }
    }
    sealed class MyClass2 : MyClass1
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public sealed override void ShowInfo()
        {
            Console.WriteLine("我的学号为{0},我的名字叫做{1}", id, name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();
            myclass1.ShowInfo();
            MyClass2 myclass2 = new MyClass2();
            myclass2.Id = "12021051064";
            myclass2.Name = "华心童";
            myclass2.ShowInfo();
            MyClass1 myclass3 = new MyClass2() { Id = "12021051064", Name = "Jason" };
            myclass3.ShowInfo();
            Console.ReadKey();
        }
    }
}