using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConnStr = @"Data Source=LAPTOP-868L7ATP\JASON;Initial Catalog=SchoolInfo;User ID=sa;Password=hxt200388";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnStr;
            conn.Open();
            string sql = "select count(*) from Student ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Connection=conn;指定连接桥
            //cmd.CommandText = sql;执行的Sql语句
            //cmd.CommandType = CommandType.Text;默认类型为Sql语句，CommandType.StoredProcedure为存储过程
            double d=(double)cmd.ExecuteScalar();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine("学号：{0}，姓名：{1}", reader[0].ToString(), reader[1].ToString());
            //}
            //reader.Close();
            conn.Close();
           
        }
    }
}
