using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace P1602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float x1 = 0.0F, x2 = 0.0F, x = 0.0F;
            char op = '+';
            x1=Convert.ToSingle(textBox3.Text);
            op=Convert.ToChar(comboBox1.Text);
            x2=Convert.ToSingle(textBox4.Text);
            Operator obj = null;
            switch(op)
            {
                case '+':
                    obj = new ADD();
                    break;
                case '-':
                    obj = new SUB();
                    break;
                case '*':
                    obj = new MUL();
                    break;
                case '/':
                    obj = new DIV();
                    break;
                default:
                    break;
            }
            if(obj!=null)
            {
                obj.A = x1;
                obj.B= x2;
                x = obj.Compute();
            }
            textBox6.Text = x.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}