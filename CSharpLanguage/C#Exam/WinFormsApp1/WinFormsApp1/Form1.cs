using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = @"D:\C#自我练习\save.txt";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save s = new Save();
            if (radioButton1.Checked)
            {
                s.LeiXing = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                s.LeiXing = radioButton2.Text;
            }
            s.LeiBie = comboBox1.Text;
            s.XiangMu = textBox1.Text;
            s.RiQi = dateTimePicker1.Text;
            s.ShuoMin = textBox1.Text;
            if (checkBox1.Checked)
            {
                s.ShouZhipeople = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                s.ShouZhipeople = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                s.ShouZhipeople = checkBox3.Text;
            }
            else if (checkBox4.Checked)
            {
                s.ShouZhipeople = checkBox4.Text;
            }
            else if (checkBox5.Checked)
            {
                s.ShouZhipeople = checkBox5.Text;
            }
            else if (checkBox6.Checked)
            {
                s.ShouZhipeople = checkBox6.Text;
            }
            s.Money = numericUpDown1.ToString();
            s.BeiZhu = richTextBox2.Text;
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s.LeiXing);
            sw.Write(s.LeiBie);// s.LeiBie, s.XiangMu, s.RiQi, s.ShuoMin, s.ShouZhipeople, s.Money, s.BeiZhu
            sw.Write(s.XiangMu);
            sw.Write(s.RiQi);
            sw.Write(s.ShuoMin);
            sw.Write(s.ShouZhipeople);
            sw.Write(s.Money);
            sw.Write(s.BeiZhu);
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("保存成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}