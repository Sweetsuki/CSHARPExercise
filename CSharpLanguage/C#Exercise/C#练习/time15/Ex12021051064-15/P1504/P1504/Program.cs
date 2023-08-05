using System;
using System.IO;
namespace P1504
{
    class Program
    { 
        static void Main(string[] args)
        {
            string path1 = @"D:\score.dat";
            string path2 = @"D:\scorebak.dat";
            double[] score = { 85.5, 78.6, 59.7, 89.2, 45.2 };
            FileStream fs1 = new FileStream(path1, FileMode.OpenOrCreate);
            BinaryWriter bw1 = new BinaryWriter(fs1);
            for (int i = 0; i < 5; i++)
            {
                bw1.Write(score[i]);
            }
            bw1.Flush();
            bw1.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(path1, FileMode.Open);
            FileStream fs3 = new FileStream(path2, FileMode.OpenOrCreate);
            BinaryReader br1 = new BinaryReader(fs2);
            BinaryWriter bw2 = new BinaryWriter(fs3);
            for (int i = 0; i < br1.BaseStream.Length; i++)
            {
                bw2.Write(br1.ReadByte());
            }
            bw1.Close();
            bw2.Close();
            fs3.Close();
            FileStream fs4 = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br2 = new BinaryReader(fs4);
            Console.WriteLine("-------分界线-------");
            Console.Write("输入第2门成绩:");
            br1.BaseStream.Seek(8, SeekOrigin.Begin);
            Console.WriteLine(br1.ReadDouble());
            Console.WriteLine("-------分界线-------");
            Console.Write("输入第5门成绩:");
            br1.BaseStream.Seek(32, SeekOrigin.Begin);
            Console.WriteLine(br1.ReadDouble());
            br2.Close();
            fs4.Close();
        }
    }
}