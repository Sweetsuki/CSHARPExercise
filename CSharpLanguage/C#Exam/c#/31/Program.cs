using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _31._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\e1.txt";
                string path1 = @"D:\e1.txt";
                string path2 = @"D:\f000.txt";
                int count = 0;
                if (!File.Exists(path))
                {
                    Console.WriteLine("提示：文件不存在。");
                }
                else
                {
                    File.Copy(path, path1);//复制
                                           //File.Move(path,path1);//移动
                }
                if (!File.Exists(path1))
                {
                    Console.WriteLine("提示：文件不存在。");
                }
                else
                {
                    File.Delete(path1);
                }
                FileStream fs1 = new FileStream(path2,FileMode.Open);
                StreamReader sr1 = new StreamReader(fs1);
                int content = sr1.Read();
                while (content != -1)
                {
                    //Console.WriteLine("单个字符读出" + Convert.ToChar(content));
                    if (content == 'A')
                    {
                        count++;
                    }
                    content = sr1.Read();
                }
                Console.WriteLine("A字符出现了" + count + "次");
                sr1.Close();
                fs1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
