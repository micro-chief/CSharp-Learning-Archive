namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        float[,] a = new float[100, 100];
        int i, j, n, m;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text); // определяем число строк
            m = Convert.ToInt32(textBox2.Text); // определяем число столбцов
            dataGridView1.RowCount = n; // задаем размеры таблицы
            dataGridView1.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(0, 21) - 10;
                    dataGridView1[j, i].Value = Convert.ToString(a[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}