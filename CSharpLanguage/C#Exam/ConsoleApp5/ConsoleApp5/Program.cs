//using System;
//namespace P5
//{
//    abstract class Vehicle
//    {
//        private float speed;
//        public float Speed
//        {
//            get { return speed; }
//            //set { speed = value; }
//        }
//        public virtual float Run(float distance)
//        {
//            return speed;
//        }
//        public abstract void Speak();
//        public Vehicle(float speed)
//        {
//            this.speed = speed;
//        }
//    }
//    class Train:Vehicle
//    {
//        public Train():base(160)
//        { }
//        public override void Speak()
//        {
//            Console.WriteLine("呜......");
//        }
//    }
//    abstract class Automobile:Vehicle
//    {
//        public Automobile(float speed):base(speed)
//        { }
//        public override abstract void Speak();
//    }
//    class Truck:Automobile
//    {
//        private float weight;
//        public float Weight
//        {
//            get { return weight; }
//            set { weight = value; }
//        }
//        private float load;
//        public float Load
//        {
//            get { return load; }
//            //set { load= value; }
//        }
//        public Truck(int weight,int load):base(50)
//        {
//            this.weight = weight;
//            this.load = load;
//        }
//        public override float Run(float distance)
//        {
//            return (1+load/weight/2)*base.Run(distance);
//        }
//        public override void Speak()
//        {
//            Console.WriteLine("叭......叭......");
//        }
//    }
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Vehicle v1 = new Train();
//            v1.Speak();
//            Console.WriteLine("行驶1000公里需{0}小时",v1.Run(1000));
//            v1 = new Truck(16,24);
//            v1.Speak();
//            Console.WriteLine("行驶1000公里需要{0}小时",v1.Run(1000));
//            Console.ReadKey();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0103
{
    class Vehicle
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Move()
        {
            Console.WriteLine("我在移动");
        }
        public virtual void Speak()
        {
            Console.WriteLine("我在鸣笛");
        }
    }
    class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("哗啦哗啦");
        }
        public override void Speak()
        {
            Console.WriteLine("dididi");
        }
    }
    class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("杜拉杜拉");
        }
        public override void Speak()
        {
            Console.WriteLine("嘶嘶嘶嘶");
        }
    }
    class Program
    {
        static Vehicle[] GetVehs()
        {
            Vehicle[] veh = new Vehicle[3];
            veh[0] = new Vehicle() { Name = "交通工具" };
            veh[1] = new Train() { Name = "火车" };
            veh[2] = new Car() { Name = "小汽车" };
            return veh;
        }
        static void Main(string[] args)
        {
            foreach (Vehicle v in GetVehs())
            {
                v.Move();
                v.Speak();
            }
        }
    }
}
