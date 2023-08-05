using System;
namespace Exercise22
{
    class Employee
    {
        private double bsalary = 1000;
        private double psalary;
        public double Psalary
        {
            get {return psalary;} 
            set {psalary = value;}
        }
        private int n;
        public int pn
        {
            get { return n; }
            set { n = value; }
        }
        public Employee(double bsalary, int n)
        {
            this.bsalary = bsalary;
            this.pn = n;
        }
        public virtual double Compsalary()
        {
            //Console.WriteLine("普通职工，工作年数："+pn);
            psalary = bsalary + 30 * pn;
            return psalary;
        }
    }
    class UEmployee:Employee//本科生职工类
    {
        public UEmployee(double bsalary, int n):base(bsalary, n)
        {
            this.pn= n;
        }
        public override double Compsalary()
        {
            //base.Compsalary();
            //Console.WriteLine("本科生职工，工作年数："+pn);
            return 1.5* base.Compsalary();
        }
    }
    class VEmployee:Employee//研究生职工类
    {
        public VEmployee(double bsalary, int n):base(bsalary, n) 
        {
            this.pn= n;
        }
        public override double Compsalary()
        {
            //base.Compsalary();
            //Console.WriteLine("研究生职工，工作年数：" + pn);
            return 2* base.Compsalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(10000, 4);
            Console.WriteLine("普通职工工资：" + obj.Compsalary()); //10120
            obj = new UEmployee(10000, 4);
            Console.WriteLine("本科生职工工资：" + obj.Compsalary()); //15180
            obj = new VEmployee(10000, 4);
            Console.WriteLine("研究生职工工资：" + obj.Compsalary()); //20240
        }
    }
}