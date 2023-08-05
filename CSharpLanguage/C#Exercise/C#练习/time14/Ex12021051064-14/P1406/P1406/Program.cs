using System;
using System.IO;
namespace P1406
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"D:\Jason.txt";
            string target = @"D:\Tom.txt";
            using(FileStream fsRead=new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate))
                {
                    byte[] buffer = new byte[1024];
                    while(true)
                    {
                        int r = fsRead.Read(buffer,0,buffer.Length);
                        if(r<=0) break;
                        fsWrite.Write(buffer,0,buffer.Length);
                    }
                }
            }
            Console.WriteLine("文件d内容已写入文件e中");
            Console.ReadKey();
        }
    }
}