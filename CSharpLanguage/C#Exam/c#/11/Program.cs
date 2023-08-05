using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] arr = email.Split('@');
            Console.WriteLine("用户名为{0}，邮箱地址为{1}", arr[0], arr[1]);
        }
    }
}
