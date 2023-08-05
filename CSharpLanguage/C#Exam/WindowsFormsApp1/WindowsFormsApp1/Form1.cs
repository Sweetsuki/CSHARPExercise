using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string ConnStr = @"Data Source=LAPTOP-868L7ATP\JASON;Initial Catalog=SchoolInfo;User ID=sa;Password=hxt200388";
            //SqlConnection conn=new SqlConnection();//建立连接桥
            //conn.ConnectionString = ConnStr;//指定连接字符串
            //conn.Open();//打开连接桥
            //string sql = "select * from Student";
            //SqlCommand cmd = new SqlCommand(sql, conn);//创建命令对象
            //SqlDataReader reader = cmd.ExecuteReader();//执行查询命令，获得DataReader
            //while(reader.Read())
            //{
            //    Console.WriteLine("学号：{0}，姓名：{1}", reader[0].ToString(), reader[1].ToString());
            //}
            ////DataTable tb=new DataTable();
            ////tb.Load(reader);
            //reader.Close();
            //conn.Close();
            ////DataGridView1.DataSource = tb;  

        }
        //连接
        SqlConnection conn = new SqlConnection();//建立连接桥
        private void button1_Click(object sender, EventArgs e)
        {
            string ConnStr = System.Configuration.ConfigurationManager.connectionStrings["constr"].ToString();
            //string ConnStr = @"Data Source=LAPTOP-868L7ATP\JASON;Initial Catalog=SchoolInfo;User ID=sa;Password=hxt200388";
            SqlConnection conn = new SqlConnection();//建立连接桥
            //conn.ConnectionString = ConnStr;//指定连接字符串
            conn.Open();//打开连接桥
            MessageBox.Show("连接成功！","提示：",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            string sql = "select * from Student";
            SqlCommand cmd = new SqlCommand(sql, conn);//创建命令对象
            SqlDataReader reader = cmd.ExecuteReader();//执行查询命令，获得DataReader
            DataTable tb = new DataTable();
            tb.Load(reader);
            reader.Close();
            conn.Close();
            //显示数据
            dataGridView1.DataSource = tb; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
                

            if (conn.State == ConnectionState.Open)
                conn.Close();

        }
    }
}
