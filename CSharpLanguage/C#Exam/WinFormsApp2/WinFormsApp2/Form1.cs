namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        bool isDisplay = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\Users\18351154069\Pictures\Saved Pictures\OIP-C.jfif";
            this.Opacity = 0;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (isDisplay)
                {
                    if (this.Opacity + 0.02 < 1)
                        this.Opacity += 0.02;
                    else
                    {
                        timer1.Enabled = false;
                        //System.Threading.Thread.Sleep(1000);
                        isDisplay = false;
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    if (this.Opacity - 0.02 > 0)
                        this.Opacity -= 0.02;
                    else
                    {
                        timer1.Enabled = false;
                        
                    }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Form fm = new Form();
            fm.Show();
            this.Hide();
        }
    }
}