//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication4
//{
//    class Student:IComparable
//    {
//        private int no;
//        public int No
//        {
//            get { return no; }
//            set { no = value; }
//        }
//        private string name;
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        private float score;
//        public float Score
//        {
//            get { return score; }
//            set { score = value; }
//        }
//        public Student(int no,string name,float score)
//        {
//            this.no = no;
//            this.name = name;
//            this.score = score;
//        }
//        public void Display()
//        {
//            Console.WriteLine("\t{0}\t{1}\t{2}",No,Name,Score);
//        }
//        //public int Compare(Object obj1, Object obj2)
//        //{
//        //    string s1 = (string)obj1;
//        //    string s2 = (string)obj2;
//        //    int temp = s1.Length - s2.Length;
//        //    return temp;
//        //}
//        public int CompareTo(object obj)
//        {
//            Student s1 = (Student)obj;
//            if (this.score > s1.score) return -1;
//            else if (this.score == s1.score) return 0;
//            //else return 1;
//            //return 0;
//            //if (this.score != s1.score)
//            //    return s1.score.CompareTo(this.score);
//            else if (this.no != s1.no&& !this.name.Equals(s1.name))
//                return s1.no.CompareTo(this.no);
//            //else if (!this.name.Equals(s1.name))
//            //    return this.name.CompareTo(s1.name);
//            return 0;

//        }

//    }
//    class Program
//    {
//        static void DispStu(ArrayList myarr, string str)
//        {

//            Console.WriteLine(str);
//            Console.WriteLine("————————————————");
//            Console.WriteLine("\t学号\t姓名\t分数");
//            foreach(Student s in myarr )
//            {
//                s.Display();
//            }
//        }
//        static void Main(string[] args)
//        {
//            int n = 4;
//            ArrayList myarr = new ArrayList();
//            Student[] ST = new Student[4] { new Student(5,"Keven",78),new Student(1, "Daniel", 85),new Student(8,"John",100),new Student(2,"Jason",100) };
//            for(int i=0;i<n;i++)
//            {
//                myarr.Add(ST[i]);
//            }
//            DispStu(myarr, "排序前：");
//            myarr.Sort();
//            DispStu(myarr, "按分数排序后：");
//            Console.ReadKey();
//        }
//    }
//}
using System;
using System.Collections;
namespace ConsoleApplication4
{
    class Student : IComparable
    {
        private int no;
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private float score;
        public float Score
        {
            get { return score; }
            set { score = value; }
        }
        public Student(int no, string name, float score)
        {
            this.no = no;
            this.name = name;
            this.score = score;
        }
        public void Display()
        {
            Console.WriteLine("\t{0}\t{1}\t{2}", No, Name, Score);
        }
        public int CompareTo(object obj)
        {
            Student s1 = (Student)obj;
            //只排分数
            //if (this.score > s1.score) return -1;
            //else if (this.score == s1.score) return 0;
            //else return 1;

            if (this.score != s1.score)
                return s1.score.CompareTo(this.score);
            //排的分数和姓名
            //else if (this.no != s1.no && !this.name.Equals(s1.name))
            //    return this.name.CompareTo(s1.name);
            //排的分数和学号 
            else if (this.no != s1.no && !this.name.Equals(s1.name))
                return this.no.CompareTo(s1.no);
            return 0;
        }

    }
    class Program
    {
        static void DispStu(ArrayList myarr, string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("————————————————");
            Console.WriteLine("\t学号\t姓名\t分数");
            foreach (Student s in myarr)
            {
                s.Display();
            }
        }
        static void Main(string[] args)
        {
            int n = 4;
            ArrayList myarr = new ArrayList();
            Student[] ST = new Student[4] { new Student(1, "Daniel", 85), new Student(5, "Keven", 78), new Student(2, "John", 100), new Student(8, "Jason", 100) };
            for (int i = 0; i < n; i++)
            {
                myarr.Add(ST[i]);
            }
            DispStu(myarr, "排序前：");
            myarr.Sort();
            DispStu(myarr, "按分数排序后：");
            Console.ReadKey();
        }
    }
}