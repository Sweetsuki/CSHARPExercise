using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Program
    {
        public class Automobile //汽车类定义
        {
            protected float speed;
            private float weight;
            public Automobile() { }
            public Automobile(float speed, float weight)
            { 
                this.speed = speed; 
                this.weight = weight;
            }
            public virtual void Speek()
            {
                Console.WriteLine("汽车鸣笛！"); 
            }
            public void Show()
            {
                Console.WriteLine("速度：{0}，重量：{1}", speed, weight);
            }
        }
        class Truck:Automobile
        {
            private float load;
            public Truck() : base() { }
            public Truck(float speed, float weight,float load):base(speed,weight)
            {
                this.load = load;
            }
            public new void Show()
            {
                base.Show();
                Console.WriteLine("载重：{0}",load);
            }
            public override void Speek()
            {
                Console.WriteLine("卡车鸣笛！");
            }
        }
        static void Main(string[] args)
        {
            Automobile a = new Automobile(90,1.5f);
            a.Show();
            a.Speek();
            Truck x000;
            x000 = new Truck(100f, 2f, 1.5f);
            x000.Show(); //速度：100，重量：2 <CR>载重：1.5
            x000.Speek();

        }
    }
}
