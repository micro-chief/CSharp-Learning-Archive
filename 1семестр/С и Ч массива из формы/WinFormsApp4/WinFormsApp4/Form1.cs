using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        float[] a = new float[1000];
        int n;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            for (int i = 0; i < n; i++)
            {
                float temp = rand.Next(1, 99); // создаем случайное число от 1 до 99 (дробного типа но без дробной части)
                a[i] = temp / 10; // добавляем дробную часть
                textBox2.Text = textBox2.Text + Convert.ToString(a[i]) + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"; // настраиваем фильтр при сохранении файла
            saveFileDialog1.ShowDialog(); // вызываем метод открытия диалогового окна
            string f = saveFileDialog1.FileName; // в f будем хранить имя файла для сохранения массива
            System.IO.File.WriteAllText(f, textBox2.Text); // сохраняем содержимое textBox2.Text в файл
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"; // настраиваем фильтр при открытии файла
            openFileDialog1.ShowDialog(); // вызываем метод открытия диалогового окна
            string f = openFileDialog1.FileName; // в f будем хранить имя файла из которого будем считывать массив
            textBox2.Text = System.IO.File.ReadAllText(f); // переносим содержимое файла в textBox2.Text
            MessageBox.Show(" Файл открыт "); // что бы пользователь пощелкал мышкой :)
        }
    }
}