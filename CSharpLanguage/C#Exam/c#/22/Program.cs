using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    internal class Program
    {
        class Employee
        {
            private double bsalary=1000.0;
            private double psalary;
            private int n;
            public int pn
            {
                get { return n; }
                set { n = value; }
            }
            public Employee(double bsalary, int n)
            {
                this.bsalary = bsalary;
                this.n = n;
               
            }
            public double Compsalary()
            {
                psalary = bsalary + 30 * n;
                return psalary;
            }
        }
        class UEmployee:Employee
        {
            public UEmployee(double bsalary, int n) : base(bsalary,n) { }
            public new double Compsalary()
            {
                return base.Compsalary() * 1.5;
            }
        }
        class VEmployee : Employee
        {
            public VEmployee(double bsalary, int n) : base(bsalary, n) { }
            public new double Compsalary()
            {
                return base.Compsalary() * 2;
            }
        }
        static void Main(string[] args)
        {
            Employee obj1 = new Employee(10000, 4);
            Console.WriteLine(obj1.Compsalary()); //10120
            UEmployee obj2=new UEmployee(10000,4);
            Console.WriteLine(obj2.Compsalary()); //15180
            VEmployee obj3 =new VEmployee (10000,4);
            Console.WriteLine(obj3.Compsalary());//20240
        }
    }
}
