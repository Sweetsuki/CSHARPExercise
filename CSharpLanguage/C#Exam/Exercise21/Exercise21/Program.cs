using System;
namespace Exercise21
{
    class Automobile
    {
        protected float speed;
        private float weight;
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Automobile() { }
        public Automobile(float speed, float weight)
        {
            this.speed = speed;
            this.weight = weight;
        }
        public virtual void  Speak()
        {
            Console.WriteLine("汽车鸣笛！");
        }
        public virtual void Show()
        {
            Console.WriteLine("速度：{0}，重量：{1}",speed,weight);
        }
    }
    class Truck:Automobile
    {
        protected float load;
        public Truck() { }
        public Truck(float speed,float weight,float load)
        {
            this.speed=speed;
            this.Weight=weight;
            this.load=load;
        }
        public override void Show()
        {
            Console.WriteLine("速度:{0},重量:{1}吨\r 载重:{2}吨", speed, Weight,load);
        }
        public override void Speak()
        {
            Console.WriteLine("卡车鸣笛......\r");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobile a = new Automobile(90, 1.5f);
            a.Show();
            a.Speak();
            Truck x000;
            x000 = new Truck(100f, 2f, 1.5f);
            x000.Show();
            x000.Speak();
        }
    }
}