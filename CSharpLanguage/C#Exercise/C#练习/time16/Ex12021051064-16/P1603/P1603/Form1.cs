using System.Security.Cryptography.X509Certificates;

namespace P1603
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("��������");
            comboBox1.Items.Add("�̶��ʲ�");
            comboBox1.Items.Add("��������");
            comboBox1.Items.Add("ҽ��ҩƷ");
            comboBox1.Items.Add("������ѵ");
            comboBox1.Items.Add("���鿪֧");
            comboBox1.Items.Add("����֧��");
            numericUpDown1.Maximum = 100000;
            numericUpDown1.Minimum = 1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save s = new Save();

            if (radioButton1.Checked)
            {
                s.Type = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                s.Type= radioButton2.Text;
            }
            s.Category = comboBox1.Text;
            s.Event = richTextBox1.Text;
            s.Date = dateTimePicker1.Text;
            s.ShuoMin = textBox1.Text;
            //if (checkBox1.Checked)
            //{
            //    s.ShouZhipeople = checkBox1.Text;
            //}
            //else if (checkBox2.Checked)
            //{
            //    s.ShouZhipeople = checkBox2.Text;
            //}
            //else if (checkBox3.Checked)
            //{
            //    s.ShouZhipeople = checkBox3.Text;
            //}
            //else if (checkBox4.Checked)
            //{
            //    s.ShouZhipeople = checkBox4.Text;
            //}
            //else if (checkBox5.Checked)
            //{
            //    s.ShouZhipeople = checkBox5.Text;
            //}
            //else if (checkBox6.Checked)
            //{
            //    s.ShouZhipeople = checkBox6.Text;
            //}
            s.Money = numericUpDown1.Text.ToString();
            s.BeiZhu = richTextBox2.Text.ToString();
            string filename = @"D:\C#\save.txt";
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("��֧�����"+s.Type);
            sw.WriteLine("��֧���"+s.Category);// s.LeiBie, s.XiangMu, s.RiQi, s.ShuoMin, s.ShouZhipeople, s.Money, s.BeiZhu
            sw.WriteLine("��֧��Ŀ��"+s.Event);
            sw.WriteLine("���ڣ�"+s.Date);
            sw.WriteLine("˵����"+s.ShuoMin);
            sw.Write("��֧�ˣ�");
            foreach (Control c in Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    sw.Write((c.Text.ToString())+" ");
                }
            }
            //List<string> list = new List<string>();
            //if (checkBox1.Checked)
            //    list.Add(checkBox1.Text);
            //if (checkBox2.Checked)
            //    list.Add(checkBox2.Text);
            //if (checkBox3.Checked)
            //    list.Add(checkBox3.Text);
            //if (checkBox4.Checked)
            //    list.Add(checkBox4.Text);
            //if (checkBox5.Checked)
            //    list.Add(checkBox5.Text);
            //if (checkBox6.Checked)
            //    list.Add(checkBox6.Text);
            //string res=string.Join(" ", list.ToArray());
            //s.ShouZhipeople=string.Format("��֧�ˣ�"+res);
            sw.WriteLine(s.ShouZhipeople);
            sw.WriteLine("��"+s.Money);
            sw.WriteLine("��ע��"+s.BeiZhu);
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("����ɹ���","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}