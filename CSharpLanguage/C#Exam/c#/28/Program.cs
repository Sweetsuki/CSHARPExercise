using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _28
{
    internal class Program
    {
        class A
        {
            int x,y;
            public A(int x, int y) 
            { 
                this.x = x;
                this.y = y;
            }
            public void Show() 
            {
                Console.WriteLine("{0},{1}", x, y);
            }
        }
        static void Main(string[] args)
        {
            A[] a = { new A(1, 2), new A(2, 2), new A(3, 2) };
            List<A> arr1 = new List<A>();         
            for(int i=0;i<3;i++)
            {
                a[i].Show();
            }
        }
    }
}
