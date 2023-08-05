using System;
namespace P1101
{
    abstract class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Animal() { }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Born()
        {
            Console.WriteLine("姓名：{0}，年龄：{1}", name, age);
        }
        public virtual void Speak(string voice)
        {
            Console.WriteLine("发出了" + voice + "的声音");
        }
        public abstract void Eat(string food);

    }
    class Cat : Animal
    {
        public Cat() { }
        public Cat(string name, int age) : base(name, age)
        {

        }
        public new void Born()
        {
            base.Born();
        }
        public override void Speak(string voice)
        {
            base.Speak(voice);
        }
        public override void Eat(string food)
        {
            Console.WriteLine("{0}爱吃{1}", Name, food);
        }
    }
    class Dog : Animal
    {
        public Dog() { }
        public Dog(string name, int age) : base(name, age)
        {

        }
        public new void Born()
        {
            base.Born();
        }
        public override void Speak(string voice)
        {
            base.Speak(voice);
        }
        public override void Eat(string food)
        {
            Console.WriteLine("{0}爱吃{1}", Name, food);
        }
    }
    abstract class Cow : Animal
    {
        public Cow() { }
        public Cow(string name, int age) : base(name, age)
        {

        }
        public new void Born()
        {
            base.Born();
        }
        public override void Speak(string voice)
        {
            base.Speak(voice);
        }
        public override abstract void Eat(string food);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Cat() { Name = "招财", Age = 4 };
            a1.Born();
            a1.Speak("喵喵...");
            a1.Eat("鱼");
            Animal a2 = new Dog() { Name = "卡卡", Age = 6 };
            a2.Born();
            a2.Speak("汪汪...");
            a2.Eat("骨头");

            Console.ReadKey();
        }
    }
}
