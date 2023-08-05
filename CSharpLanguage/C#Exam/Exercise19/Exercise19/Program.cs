using System;
namespace Exercise19
{
    class MyTime
    {
        private int hour;
        public int Hour
        {
            get { return hour; }
        }
        private int minute;
        public int Minute
        {
            get { return minute; }
        }
        private int second;
        public int Second
        {
            get { return second; }
            set { second = value; }
        }
        public MyTime()
        {

        }
        public MyTime(int hour,int minute,int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void Show()
        {
            Console.WriteLine("输出 {0}:{1}:{2}",hour,minute,second);
        }
        public static bool operator ==(MyTime t1, MyTime t2)
        {
            if((t1.hour == t2.hour) && (t1.minute == t2.minute) && (t1.second == t2.second))
                return true;
            return false;
        }
        public static bool operator !=(MyTime t1,MyTime t2)
        {
            if ((t1.hour == t2.hour) && (t1.minute == t2.minute) && (t1.second == t2.second))
                return false;
            return true;
        }
        public static MyTime operator + (MyTime t1,int x)
        {
            if (t1.second + x >= 60)
            {
                t1.minute++; 
                t1.second=(t1.second +x)%60;
                if(t1.minute>=60)
                {
                    t1.hour++;
                    t1.minute= (t1.second + x) % 60;
                }
            }
            else
            {
                t1.second += x;
            }
            return new MyTime(t1.hour,t1.minute,t1.second);
        }
        public static MyTime operator ++(MyTime t2)
        {
            Console.WriteLine("执行重载运算符++");
            return new MyTime(t2.hour,t2.minute,++t2.second);
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            MyTime t1=new MyTime(12,8,50),t2,t3;
            t2 = new MyTime(12,9,0);
            //t3=new MyTime(12,10,0);
            if(t1==t2)
            {
                Console.WriteLine("时间相同！");
            }
            else if(t1!=t2)
            {
                Console.WriteLine("时间不同！");
            }
            t3 = t1 + 12;
            t3.Show();
            //t3 = ++t2;
            //t3.Show();
            t3 = ++t2;
            t3.Show();
            // 输出 12:9:1 //再试试后置++
            t3 = t2++;
            t3.Show();
        }
    }
}
