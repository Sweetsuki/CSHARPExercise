using System;
namespace Exercise18
{
    class MyPoint
    {
        private int x;
        public int PX
        {
            get { return x; }
            set { x = value; }
        }
        private int y;
        public int PY
        {
            get { return y; }
            set { y = value; }
        }
        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void ShowPoint()
        {
            Console.WriteLine("该点坐标是：（{0},{1}）",x,y);
        }
        ~MyPoint()
        {
            Console.WriteLine("点({0},{1})被析构", x, y);
        }
        public double Disp()
        {
            double distance = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
            return distance;
        }
        public  double Disp(MyPoint p)
        {
            double distance=Math.Sqrt(Math.Pow(x-p.x,2)+Math.Pow(y-p.y,2));
            return distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint mp = new MyPoint();
            mp.ShowPoint();
            MyPoint mp1=new MyPoint(3,4);
            mp1.ShowPoint();
            MyPoint p=new MyPoint(6,8);
            p.ShowPoint();
            Console.WriteLine("当前坐标到形参p点的距离为："+p.Disp(mp1));
            Console.WriteLine("当前坐标到原点的距离为："+mp1.Disp());
        }
    }
}