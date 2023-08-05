using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    internal class Program
    {
        class MyTime
        {
            private int hour;
            private int minute;
            private int second;
            public int Hour
            {
                get { return hour; }
            }
            public int Minute
            {
                get { return minute; }
            }
            public int Second
            {
                get { return second; }
                set {second = value; }
            }

            public MyTime() { }
            public MyTime(int hour,int minute,int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }
            public void Show()
            {
                Console.WriteLine("t3时间：{0}:{1}:{2}",hour,minute,second);
            }
            public static MyTime operator +(MyTime t1,int t)
            {              
 
                t1.second = t1.second + t;
                if (t1.second >= 60)
                {
                    t1.minute += t1.second / 60;
                    t1.second = t1.second % 60;
                    
                }
                if(t1.minute>=60)
                {
                    t1.hour += t1.minute / 60;
                    t1.minute = t1.minute % 60;                  ;
                }
                return t1;
            }
            public static bool operator == (MyTime t1, MyTime t2)
            {
                bool status = false;
                if (t1.hour == t2.hour && t1.minute == t2.minute && t1.second == t2.second)
                {
                    status = true;
                }
                return status;
            }
            public static bool operator !=(MyTime t1, MyTime t2)
            {
                bool status = false;
                if (t1.hour != t2.hour && t1.minute != t2.minute && t1.second != t2.second)
                {
                    status = true;
                }
                return status;
            }
            public static MyTime operator ++(MyTime t2)
            {
                return new MyTime(t2.hour,t2.minute, 1 + t2.second);
            }
        }
        static void Main(string[] args)
        {
            MyTime t1 = new MyTime(12, 8, 50), t2, t3;
            t2 = new MyTime(12, 9, 0);
            if (t1 == t2) Console.WriteLine("时间相同");
            else Console.WriteLine("时间不相同");
            int t = 12;
            t3 = t1 + t;
            t3.Show();//输出 12:9:2
            t3 = ++t2; 
            t3.Show();//输出 12:9:1 再试试后置++
            t3 = t2++;
            t3.Show();
        }
    }
}
