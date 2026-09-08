namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        float[] a = new float[1000];
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = textBox1.Lines.Count(); // количество строк
            textBox3.Text = Convert.ToString(n);
            textBox2.Clear();
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToSingle(textBox1.Lines[i]);
                textBox2.Text = textBox2.Text + Convert.ToString(a[i]) + "\r\n"; // здесь будет обработка массива
            }
        }
    }
}