using System;
namespace P901
{
    class Employee
    {
        private double bSalary = 1000;
        private double pSalary;
        public double PSalary
        {
            get { return pSalary; }
            set { pSalary = value; }
        }
        private int n;
        public int PN
        {
            get { return n; }
            set { n = value; }
        }
        public void CompSalary()
        {
            Console.WriteLine("普通职工：");
            Console.Write("工作年数：");
            n = int.Parse(Console.ReadLine());
            pSalary = bSalary + 30 * n;
            Console.WriteLine("该普通职工工资：" + pSalary);
        }
    }
    class UEmployee : Employee
    {

        public new void CompSalary()
        {
            base.CompSalary();
            Console.WriteLine("本科生职工：");
            Console.WriteLine("工作年数：" + PN);
            Console.WriteLine("该本科生职工工资：" + 1.5 * PSalary);
        }
    }
    class VEmployee : UEmployee
    {
        public new void CompSalary()
        {
            base.CompSalary();
            Console.WriteLine("研究生职工：");
            Console.WriteLine("工作年数：" + PN);
            Console.WriteLine("该研究生职工工资：" + 2 * PSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VEmployee employee1 = new VEmployee();
            employee1.CompSalary();
            Console.ReadKey();
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace P009
//{
//    public class Employee
//    {
//        public double bSalary = 1000;
//        public double pSalary;
//        private int year;
//        public int PN
//        {
//            get { return year; }
//            set { year = value; }

//        }
//        public double ComSalary()
//        {
//            pSalary = bSalary + (30 * year);
//            return pSalary;
//        }
//        public void print()
//        {
//            Console.WriteLine("普通职工:");
//            Console.Write("工作年份:");
//            year = int.Parse(Console.ReadLine());
//            Console.WriteLine("该普通职工工资:{0}", ComSalary());

//        }
//    }
//    public class UEmplovee : Employee
//    {
//        public double Comsalary()
//        {
//            pSalary = 1.5 * base.ComSalary();
//            return pSalary;
//        }
//        public new void print()
//        {
//            Console.WriteLine("本科生职工:");
//            Console.Write("工作年份:");
//            PN = int.Parse(Console.ReadLine());
//            Console.WriteLine("该本科生职工工资:{0}", Comsalary());
//        }
//    }
//    public class VEmplovee : Employee
//    {

//        public double ComSalary()
//        {
//            pSalary = 2 * base.ComSalary();
//            return pSalary;
//        }
//        public new void print()
//        {
//            Console.WriteLine("研究生职工:");
//            Console.Write("工作年份:");
//            PN = int.Parse(Console.ReadLine());
//            Console.WriteLine("该研究生职工工资:{0}", ComSalary());
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Employee s1 = new Employee();
//            s1.print();
//            UEmplovee s2 = new UEmplovee();
//            s2.print();
//            VEmplovee s3 = new VEmplovee();
//            s3.print();
//            Console.ReadKey();
//        }
//    }
//}

