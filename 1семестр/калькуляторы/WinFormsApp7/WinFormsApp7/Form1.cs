namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = a + b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = a - b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = a * b;
            textBox3.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = a / b;
            textBox3.Text = Convert.ToString(c);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}