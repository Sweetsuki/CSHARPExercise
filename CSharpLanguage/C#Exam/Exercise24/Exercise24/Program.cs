using System;
namespace Exercise23
{
    class myClass1
    {
        public virtual void ShowInfo()
        {
        }
    }
    sealed class myClass2:myClass1
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
            Console.WriteLine("我的学号为："+id+"，我的名字叫做："+name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass1 myclass1=new myClass1();
            myclass1.ShowInfo();
            myClass2 myclass2=new myClass2();
            myclass2.Id = "BM10001";
            myclass2.Name = "TM";
            myclass2.ShowInfo();
            myClass2 myclass3 = new myClass2() { Id= "BM10002",Name="tm" };
            myclass3.ShowInfo();
        }
    }
}