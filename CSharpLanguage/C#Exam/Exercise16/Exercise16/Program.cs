using System;
namespace Exercise16
{
    class Teacher
    {
        private string teaNo;
        public string TeaNo
        {
            get { return teaNo; }
            set { teaNo = value; }
        }
        private string teaName;
        public string TeaName
        {
            get { return teaName; }
            set { teaName = value; }
        }
        private int teaAge;
        public int TeaAge
        {
            get { return teaAge; }
            set { teaAge = value; }
        }
        private static string schoolName="";
        private static int totalNum=0;//用于统计教师对象总个数
        public Teacher() 
        {
            teaNo = "12";
            teaName = "Jason";
            teaAge = 21;
            totalNum++;
        }
        public Teacher(string TeaName)
        {
            this.teaName = TeaName;
            totalNum++;
        }
        public Teacher(string TeaNo,string TeaName,int TeaAge)
        {
            this.teaNo = TeaNo;
            this.teaName= TeaName;
            this.teaAge = TeaAge;
            totalNum++;
        }
        public void SetSchool(string newname)
        {
            schoolName=newname;
        }
        public void ShowInfo()
        {
            Console.WriteLine("教师信息如下：");
            Console.WriteLine("老师工号："+teaNo);
            Console.Write("老师姓名："+teaName);
            Console.Write("老师年龄："+teaAge);
            Console.Write("学校名称："+schoolName);
            Console.Write("对象总数："+totalNum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1=new Teacher();
            t1.ShowInfo();
            Teacher t2 = new Teacher("Jane");
            t2.TeaNo = "08";
            t2.TeaAge = 30;
            t2.SetSchool("南京大学");
            t2.ShowInfo();
            Teacher t3 = new Teacher("30","Daniel",40);
            t3.SetSchool("东南大学");
            t3.ShowInfo();
        }
    }
}