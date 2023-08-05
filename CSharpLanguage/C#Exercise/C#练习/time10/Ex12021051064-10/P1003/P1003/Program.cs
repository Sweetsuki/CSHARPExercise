using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1003
{
    class Vehicle
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Vehicle()
        {
        }
        public Vehicle(string name)
        {
            this.name = name;
        }
        public virtual void Move()
        {
            Console.WriteLine(name+"移动");
        }
        public virtual void Speak()
        {
            Console.WriteLine(name+"鸣笛");
        }
    }
    class Train : Vehicle
    {
        public Train() { }
        public override void Move()
        {
            Console.WriteLine(Name+"快速移动");
        }
        public override void Speak()
        {
            Console.WriteLine(Name+"轰隆轰隆");
        }
    }
    class Car : Vehicle
    {
        public Car() { }
        public override void Move()
        {
            Console.WriteLine(Name+"慢慢移动");
        }
        public override void Speak()
        {
            Console.WriteLine(Name+"嘀嘀嘀");
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
            Console.ReadKey();
        }
    }
}