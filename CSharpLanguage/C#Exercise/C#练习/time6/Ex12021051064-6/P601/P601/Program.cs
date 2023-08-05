using System;
namespace P601
{
    class Point
    {
        private readonly int x;
        private int X
        {
            get { return x; }
        }
        private readonly int y;
        private int Y
        {
            get { return y; }
        }
        public  int PX;
        public  int PY;
        public Point()
        {
            this.x = x;
            this.y = y;
        }
        public Point(int x, int y)
        {
            this.PX = x;
            this.PY = y;
        }
        public void ShowPoint()
        {
            Console.WriteLine("该点的坐标是：({0},{1})",PX,PY);
        }
        ~Point()
        {
            Console.WriteLine("点({0},{1})被析构", PX, PY);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Point P1 = new Point();
                Console.Write("请输入第一个坐标：");
                P1.PX = int.Parse(Console.ReadLine());
                P1.PY = int.Parse(Console.ReadLine());
                P1.ShowPoint();
                Point P2 = new Point();
                Console.Write("请输入第二个坐标：");
                P2.PX = int.Parse(Console.ReadLine());
                P2.PY= int.Parse(Console.ReadLine());
                P2.ShowPoint();
                double d = Math.Sqrt(Math.Pow(P2.PX - P1.PX, 2)+Math.Pow(P2.PY-P1.PY,2));
                Console.WriteLine("两点之间的距离为：{0:F2}",d);
                Console.ReadKey();
            }
        }
    }
}
