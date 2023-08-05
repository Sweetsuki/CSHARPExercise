using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void EncryFile(string sourcefile, string targetfile)
        {
            byte[] bs = File.ReadAllBytes(sourcefile);
            for (int i = 0; i < bs.Length; i++)
            {
                bs[i] ^= 15;
                File.WriteAllBytes(targetfile, bs);
            }
        }
        static void Main(string[] args)
        {
            string path1 = "D:\\Jason.txt";
            string path2 = "D:\\Durant.txt";
            string path3 = "D:\\Curry.txt";
            if (!File.Exists(path1))
            {
                string createText = "Hello,Jason" + Environment.NewLine;
                File.WriteAllText(path1, createText);
            }
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path1, appendText);
            string readTexta = File.ReadAllText(path1);
            Console.WriteLine(readTexta);
            //加密
            EncryFile(path1, path2);
            string readTextb = File.ReadAllText(path2);
            Console.WriteLine(readTextb);
            //解密
            EncryFile(path2, path3);
            string readTextc = File.ReadAllText(path2);
            Console.WriteLine(readTextc);
        }
    }
}