using System;
using System.IO;
using System.Text;
namespace P1405
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] byteDataW;
            char[] charDataW;
            using (FileStream WriteFile = new FileStream(@"D:\simons.txt",FileMode.OpenOrCreate))
            {
                Console.WriteLine("请输入一串文字：");
                string str=Console.ReadLine();
                charDataW = str.ToCharArray();
                byteDataW=new byte[charDataW.Length];
                Encoder e = Encoding.Default.GetEncoder();
                e.GetBytes(charDataW, 0, charDataW.Length, byteDataW, 0, true);
                WriteFile.Seek(0,SeekOrigin.Begin);
                WriteFile.Write(byteDataW, 0, byteDataW.Length);
                Console.WriteLine("写入成功！");
            }
            byte[] byteDataR=new byte[1024];
            char[] charDataR=new char[1024];
            using (FileStream readFile = new FileStream(@"D:\simons.txt",FileMode.OpenOrCreate))
            {
                readFile.Seek(0,SeekOrigin.Begin);
                readFile.Read(byteDataR, 0, 1024);
            }
            Decoder d=Encoding.Default.GetDecoder();
            d.GetChars(byteDataR,0,byteDataR.Length,charDataR,0);
            Console.WriteLine(charDataR);
            Console.ReadKey();
        }
    }
}