using System;
namespace P1402
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\hua";
            Directory.CreateDirectory(path);
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("存在该目录");
                    Directory.Delete(path, true);
                    Console.WriteLine("目录删除成功");
                    Directory.CreateDirectory(path);
                }
                Directory.Move(@"D:\绝密档案",path);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error："+ex.Message);
            }
            finally
            {
                Console.WriteLine(Path.GetDirectoryName(path));
                Console.WriteLine(Path.GetExtension(path));
                Console.WriteLine(Path.GetFileName(path));
                Console.WriteLine(Path.GetFileNameWithoutExtension(path));
                Console.WriteLine(Path.GetFullPath(path));
            }
        }
    }
}