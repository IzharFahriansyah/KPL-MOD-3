namespace TPMODUL3
{
    public partial class Form1 : Form
    {
        int temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
            textBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
            textBox1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
            textBox1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temp = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(temp + Convert.ToInt32(textBox1.Text));
        }
    }
}
