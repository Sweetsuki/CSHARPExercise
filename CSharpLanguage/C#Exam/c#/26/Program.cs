using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _26
{
    interface IMyinterface
    {
        void CommodityInformation();
        string Id { get; set; }
        string Name { get; set; }
    }
    class Clogistics : IMyinterface
    {
        string id = "";
        string name = "";
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        void IMyinterface.CommodityInformation()
        {
            Console.WriteLine("欢迎使用");
        }
    }
    class InClogistics : Clogistics, IMyinterface//入库信息
    {
        void IMyinterface.CommodityInformation()
        {
            Console.WriteLine("入库信息：\n" + "物件单号：" + Id + " " + "所属快递公司：" + Name);
        }
    }
    class OutClogistics : Clogistics, IMyinterface//出库信息
    {

        void IMyinterface.CommodityInformation()
        {
            Console.WriteLine("出库信息：\n" + "物件单号：" + Id + " " + "所属快递公司：" + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IMyinterface[] I = { new InClogistics(), new OutClogistics() };
            I[0].Id = "x78912345674";
            I[0].Name = "顺丰";
            I[0].CommodityInformation();

            I[1].Id = "x78945612355";
            I[1].Name = "申通";
            I[1].CommodityInformation();
        }
    }
}
