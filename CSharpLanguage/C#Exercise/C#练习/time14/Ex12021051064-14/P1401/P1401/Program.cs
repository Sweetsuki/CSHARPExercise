using System;
namespace P1401
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] LocalDrive = DriveInfo.GetDrives();
            for (int i = 0; i < LocalDrive.Length; i++)
            { 
                Console.WriteLine(string.Format("驱动器名称：{0}", LocalDrive[i].Name));
                Console.WriteLine(string.Format("存储空间大小：{0}字节", LocalDrive[i].TotalSize));
                Console.WriteLine(string.Format("可用空间大小：{0}字节", LocalDrive[i].AvailableFreeSpace));
                Console.WriteLine(string.Format("文件系统：{0}", LocalDrive[i].DriveFormat));
                Console.WriteLine(string.Format("驱动器类型：{0}", LocalDrive[i].DriveType));
                Console.WriteLine(string.Format("驱动器卷标：{0}", LocalDrive[i].VolumeLabel));
                Console.WriteLine("------------------分割线-------------------");
            }
        }
    }
}  