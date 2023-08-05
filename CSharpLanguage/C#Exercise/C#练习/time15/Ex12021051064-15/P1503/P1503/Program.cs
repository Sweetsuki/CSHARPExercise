using System;
using System.IO;
namespace P1503
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\durant1.txt";
            string target = "D:\\curry1.txt";
            FileStream fs1 = new FileStream(path, FileMode.Create);
            BinaryWriter bw1 = new BinaryWriter(fs1);
            bw1.Write(1000);
            bw1.Write(DateTime.Now.ToString());
            bw1.Write("你好，同学");
            bw1.Flush();
            bw1.Close();
            fs1.Close();
            FileStream fs2 = new FileStream(path, FileMode.Open);
            FileStream fs3 = new FileStream(target, FileMode.OpenOrCreate);
            BinaryReader br1 = new BinaryReader(fs2);
            BinaryWriter bw2 = new BinaryWriter(fs3);
            for (int i = 0; i < br1.BaseStream.Length; i++)
            {
                bw2.Write(br1.ReadByte());
            }
            bw1.Close();
            bw2.Close();
            fs2.Close();
            fs3.Close();
        }
    }
}