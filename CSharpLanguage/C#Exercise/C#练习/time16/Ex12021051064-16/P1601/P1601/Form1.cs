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
            textBox2.PasswordChar = '*';//�������Ǻ���ʾ
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String st1 = textBox1.Text.Trim();//��ȡ�ı�������
            String st2 = textBox2.Text.Trim();
            if (st1 == "" || st2 == "")
            {
                MessageBox.Show("�û��������벻������Ϊ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                MessageBox.Show("��������Ѿ�����" + ++count + "��");
            }
            else if (st1 == "18351154069" && st2 == "123456")//�Ƿ�ƥ���ж�
            {
                MessageBox.Show(st1 + "�û���½�ɹ���", "��ã�", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (st1 != "18351154069" && st2 == "123456")
            {
                MessageBox.Show("�û�������ȷ��", "��ʾ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show("��������Ѿ�����" + ++count + "��");
            }
            else if (st1 == "18351154069" && st2 != "123456")
            {
                MessageBox.Show("���벻��ȷ��", "��ʾ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show("��������Ѿ�����" + ++count + "��");
            }
            else if (st1 != "18351154069" && st2 != "123456")
            {
                MessageBox.Show("�û��������벻��ȷ��", "��ʾ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                MessageBox.Show("��������Ѿ�����" + ++count + "��");
            }               
    }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//����ı������ݣ���ͬ
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
            pictureBox1.Image = Image.FromFile("C:\\Users\\18351154069\\Desktop\\��ͼ\\Username.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\18351154069\\Desktop\\��ͼ\\Password.png");
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