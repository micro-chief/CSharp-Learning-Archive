namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int n, m, i, j;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) // загрузка формы 
        {
            dataGridView1.Columns.Add("ID", "Id"); //создаём и добавляем столбцы
            dataGridView1.Columns.Add("Fa", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Tel", "Телефон");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.Rows.Add(); //Добавляем строку с номером rowNumber
            dataGridView1.Rows[rowNumber].Cells["ID"].Value = rowNumber; //Заполняем ячейки
            dataGridView1.Rows[rowNumber].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[rowNumber].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[rowNumber].Cells["Tel"].Value = maskedTextBox1.Text; // можно по номеру столбца а можно по идентефикатору
            textBox1.Text = ""; //Стираем поля ввода для новой информации
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            n = dataGridView1.RowCount; // определяем число строк
            m = dataGridView1.ColumnCount; // определяем число столбцов
            StreamWriter sw = File.CreateText("data.txt"); //Создаём или перезаписываем существующий файл
            sw.WriteLine(Convert.ToString(n)); //Записываем текст в поток файла
            sw.WriteLine(Convert.ToString(m));
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    sw.WriteLine(Convert.ToString(dataGridView1[j, i].Value));
                }
            }
            sw.Close(); //Закрываем файл
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("data.txt"); //Создаем файловую переменную для чтения данных
            n = Convert.ToInt32(f.ReadLine()); //читаем первые две строки из файла
            m = Convert.ToInt32(f.ReadLine());
            for (i = 0; i < n - 1; i++) //перебираем строки
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells["ID"].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[1].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells[2].Value = f.ReadLine();
                dataGridView1.Rows[rowNumber].Cells["Tel"].Value = f.ReadLine();
            }
            f.Close(); //Закрываем файл
        }
    }
}