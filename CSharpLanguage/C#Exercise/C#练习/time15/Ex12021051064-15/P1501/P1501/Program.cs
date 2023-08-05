using System;
namespace P1501
{
    class Program
    {
        static void Main(string[] args) 
        {
            string path = @"D:\jason1.txt";
            FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw1 = new StreamWriter(fs1);
            sw1.WriteLine(true);
            sw1.WriteLine(88);
            sw1.WriteLine("Apple");
            sw1.Close();
            fs1.Close();
            //读入一行
            FileStream fs2 = new FileStream(path, FileMode.Open);
            StreamReader sr1 = new StreamReader(fs2);
            string line = sr1.ReadLine();
            while (line != null)
            {
                Console.WriteLine("一行读出" + line);
                line = sr1.ReadLine();
            }
            sr1.Close();
            fs2.Close();
            //读入一个字节
            FileStream fs3 = new FileStream(path, FileMode.Open);
            StreamReader sr2 = new StreamReader(fs3);
            int content = sr2.Read();
            while (content != -1)
            {
                Console.WriteLine("单个字符读出" + Convert.ToChar(content));
                content = sr2.Read();
            }
            sr2.Close();
            fs3.Close();
        }
    }
}