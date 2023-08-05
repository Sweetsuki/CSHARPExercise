using System;
using System.IO;
namespace P1403
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string path1 = "D:\\jason\\Jason1.txt";
            string path2 = "D:\\Jason1.txt";
            string path3 = "D:\\jason";
            string path4 = "E:\\Jason1.txt";
            string path5 = "D:\\jason\\Jason1.txt";
            string path6 = "D:\\jason\\Jason2.txt";
            File.Create(path4);
            FileStream f1=null;
            try
            {
                if (!Directory.Exists(path3))
                {
                    Directory.CreateDirectory(path3);
                }
                if (!(File.Exists(path1)))
                {
                    File.Create(path1);
                    Console.WriteLine("创建文件成功");
                }
                else
                {
                    Console.WriteLine("文件已存在！");
                    File.Delete(path1);
                    Console.WriteLine("删除文件并重新创建");
                    f1 = File.Create(path1);
                }
                f1.Close();
                File.Copy(path5, path6);
                Console.WriteLine("复制成功");
                File.Copy(path4, path2);//文件同名问题
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("文件访问时间" + File.GetLastAccessTime(path1));
                Console.WriteLine("文件修改时间" + File.GetLastWriteTime(path1));
                Console.WriteLine("文件创建时间" + File.GetCreationTime(path1));
                Console.WriteLine("获取在此路径上的文件的FileAttributes：" + File.GetAttributes(path1));
                File.Delete(path1);
            }
            //try
            //{
            //    string path = @"C:\jiao\SOURCE.txt";
            //    string target = @"C:\jiao\TARGET.txt";

            //    FileStream fr, fr2;
            //    if (!File.Exists(path))
            //    {
            //        fr = File.Create(path);
            //        Console.WriteLine("创建成功！");
            //    }
            //    else
            //    {
            //        File.Delete(path);
            //        Console.WriteLine("已删除！");
            //        fr = File.Create(path);
            //        Console.WriteLine("删除后创建成功！");
            //    }

            //    Console.WriteLine("文件的attribute:" + File.GetAttributes(path));
            //    Console.WriteLine("创建日期和时间:" + File.GetCreationTime(path));
            //    Console.WriteLine("上次访问的日期和时间:" + File.GetLastAccessTime(path));

            //    fr.Close();
            //    File.Copy(path, target, true);
            //    Console.WriteLine("复制成功！");

            //    File.Copy(path, path);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("同名问题" + e.Message);
            //}
        }
    }
}
//王茹玉
//    namespace p1402
//    {
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                string file = @"D:\a.txt";
//                try
//                {
//                    if (File.Exists(file))
//                    {
//                        Console.WriteLine("文件已存在!");
//                        File.Delete(file);
//                    }
//                    else
//                    {
//                        File.Create(file);
//                        Console.WriteLine("文件已创建！");
//                    }
//                    File.Copy(@"D:\b.txt", @"D:\a.txt");
//                }
//                catch (FileNotFoundException e)
//                {
//                    Console.WriteLine(e.Message);
//                }
//                finally
//                {
//                    Console.WriteLine(Path.GetFullPath(file));
//                    File.Delete(file);
//                }
//            }
//        }
//    }
//}