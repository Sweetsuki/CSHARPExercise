using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace P1505
{
    [Serializable]
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return string.Format("姓名：{0},年龄：{1}",this.Name,this.Age);
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Person person= new Person();
            person.Name = "华心童";
            person.Age = 20;
            BinaryFormatter  bf= new BinaryFormatter();
            using(FileStream fs=new FileStream("D:\\Data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                bf.Serialize(fs, person);
                Console.WriteLine("序列化操作成功，对象已写入文件");
            }
            using(FileStream fs1=new FileStream("D:\\Data.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                object obj= bf.Deserialize(fs1);
                Console.WriteLine("反序列化对象数据为"+obj);
            }
            person.ToString();
            Console.ReadKey();
        }
    }
}