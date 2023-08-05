using System;
namespace Exercise20
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
        private string teaTitle;
        public string TeaTitle
        {
            get { return teaTitle; }
            set { teaTitle = value; }
        }
        public Teacher()
        {
            teaNo = "002";
            teaName = "顾老师";
            teaAge= 37;
            teaTitle = "特级教师";
        }
        public Teacher(string teaNo,string teaName,int teaAge,string teaTitle)
        {
            this.teaNo = teaNo;
            this.teaName = teaName;
            this.teaAge = teaAge;
            this.teaTitle = teaTitle;
        }
        public virtual void Show()
        {
            Console.WriteLine("教师工号："+teaNo);
            Console.WriteLine("教师姓名："+teaName);
            Console.WriteLine("教师年龄："+teaAge);
            Console.WriteLine("教师职称："+teaTitle);
        }
    }
    class PartTimeTeacher:Teacher
    {
        private string originalSchool;
        public string OriginalSchool
        {
            get { return originalSchool;} 
            set { originalSchool = value; }       
        }
        public PartTimeTeacher(string originalSchool):base("014","陈伟",20,"jiaoshou")
        {
            //this.TeaNo = teaNo;
            //this.teaName=teaName;
            //this.TeaAge = teaAge;
            //this.TeaTitle = teaTitle;
            this.originalSchool= originalSchool;
        }
        public override void Show()
        {
            Console.WriteLine("教师工号：" + TeaNo);
            Console.WriteLine("教师姓名：" + TeaName);
            Console.WriteLine("教师年龄：" + TeaAge);
            Console.WriteLine("教师职称：" + TeaTitle);
            Console.WriteLine("教师原单位名称："+originalSchool);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t=  new Teacher();
            t.Show();
            Teacher t1=new Teacher("012","陈老师",43,"副教授");
            t1.Show();
            Teacher Mike=new PartTimeTeacher("南京大学");
            Mike.Show();
        }
    }
}