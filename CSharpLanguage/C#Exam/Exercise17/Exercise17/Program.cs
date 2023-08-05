using System;
namespace Exercise17
{
    class Customer
    {
        private string cNo;
        public string CNo
        {
            get { return cNo; }
        }
        private string cName;
        public string CName
        {
            get { return cName; }
        }
        private int cPoints;
        public int CPoints
        {
            get { return cPoints; }
            set { cPoints = value; }
        }
        private string cTelephone;
        public string CTelephone
        {
            get { return cTelephone; }
            set { cTelephone = value; }
        }
        public Customer()
        {
            //this.cNo = "001";
            //this.cName = "华心童";
            //this.cPoints = 64;
            //this.cTelephone = "181******";
        }
        public Customer(string cNo,string cName,int cPoints,string cTelephone)
        {
            this.cNo = cNo;
            this.cName = cName;
            this.cPoints = cPoints;
            this.cTelephone = cTelephone;
        }
        public void Buy(int x)
        {
            cPoints += x;
            Console.WriteLine("进行消费，为顾客添加积分:"+x+"拥有积分："+cPoints);
        }
        public void Exchange(int c)
        {
            cPoints-= c;
            Console.WriteLine("实现积分兑换，应扣除积分："+c+"拥有积分："+cPoints);
        }
        public void Show()
        {
            Console.WriteLine("顾客编号："+cNo);
            Console.WriteLine("顾客姓名：" + cName);
            Console.WriteLine("顾客的消费积分：" + 2*cPoints);
            Console.WriteLine("顾客电话：" + cTelephone);
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Customer obj=new Customer("001","华心童",64,"181****8869");
            obj.Buy(12);
            obj.Exchange(12);
            obj.Show();
        }
    }
}