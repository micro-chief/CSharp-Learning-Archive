namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int flag1;
        int x1, x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Вася";
            textBox2.Text = "Петя";
            label1.Text = "0";
            label2.Text = "0";
            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            pictureBox1.Left = x1;
            pictureBox2.Left = x2;
            flag1 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag1 = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (flag1 != 0) // Если дан старт :
            {
                if (flag1 != 0)
                {
                    Random a = new Random(); // Включаем генератор случайных чисел
                    int count = a.Next(8); // В переменную count записываем случайное число в диапазоне от 0 до 8
                    x1 += count;// Наращиваем значение координаты x1 на случайное число count
                    label1.Text = Convert.ToString(x1); // Выводим значение пройденного пути для первого игрока
                    pictureBox1.Left = x1; // Смещаем первого жучка на случайную величину
                    count = a.Next(8);// Создаём случайное число для второго игрока и повторяем всё то же самое
                    x2 += count;
                    label2.Text = Convert.ToString(x2);
                    pictureBox2.Left = x2;
                }

                if ((x1 >= 412) || (x2 >= 412)) // Проверяем какой из игроков дошёл до финиша и останавливаем процесс
                {
                    flag1 = 0;
                }
            }
        }
    }
}