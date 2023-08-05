using System;
namespace P703
{
    class ComplexNumber 
    {
        public double a;
        public double b;
        public double c;
        public ComplexNumber()
        {

        }
        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public  static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return  new ComplexNumber(c1.a + c2.a,c1.b+c2.b);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.a - c2.a, c1.b - c2.b);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.a*c2.a-c1.b*c2.b, c1.b*c2.a+c1.a*c2.b);
        }
        public static ComplexNumber operator ++(ComplexNumber c1)
        {
            return new ComplexNumber(c1.a++,c1.b++);
        }
        public void print()
        {
            Console.WriteLine("复数是：（{0}，{1}i）",a,b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(2,2.5);
            c1.print();
            ComplexNumber c2 = new ComplexNumber(4,8.5);
            c2.print();
            ComplexNumber c3 = c1 + c2;
            c3.print();
            ComplexNumber c4 = c1 - c2;
            c4.print();
            ComplexNumber c5 = c1*c2;
            c5.print();
            ComplexNumber c6= c1++;
            c6.print();
            Console.ReadKey();
        }
    }
}