using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace P1601
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';//密码以星号显示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String st1 = textBox1.Text.Trim();//获取文本框内容
            String st2 = textBox2.Text.Trim();
            if (st1 == "" || st2 == "")
            {
                MessageBox.Show("用户名和密码不能输入为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                MessageBox.Show("输入错误，已经尝试" + ++count + "次");
            }
            else if (st1 == "18351154069" && st2 == "123456")//是否匹配判断
            {
                MessageBox.Show(st1 + "用户登陆成功！", "你好！", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (st1 != "18351154069" && st2 == "123456")
            {
                MessageBox.Show("用户名不正确！", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show("输入错误，已经尝试" + ++count + "次");
            }
            else if (st1 == "18351154069" && st2 != "123456")
            {
                MessageBox.Show("密码不正确！", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show("输入错误，已经尝试" + ++count + "次");
            }
            else if (st1 != "18351154069" && st2 != "123456")
            {
                MessageBox.Show("用户名，密码不正确！", "提示", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show("输入错误，已经尝试" + ++count + "次");
            }               
    }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//清空文本框内容，下同
            textBox2.Text = "";
            textBox1.Focus();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\18351154069\\Desktop\\截图\\Username.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\18351154069\\Desktop\\截图\\Password.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}