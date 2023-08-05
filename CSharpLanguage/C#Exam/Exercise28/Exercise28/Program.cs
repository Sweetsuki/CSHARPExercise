using System;
namespace Exercise28
{
    class A
    {
        int x, y;
        public A(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Console.WriteLine("{0},{1}",x,y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A[] a = { new A(8, 8), new A(4, 5), new(1, 3) };
            //A[] a = new A[3]{new A(8,8),new A(4,5),new(1,3) };
            List<A> list = new List<A>();
            for (int i = 0; i < 3; i++)
            {
                //list.Add(a[i]);
                a[i].Show();
            }
            
        }
    }
}