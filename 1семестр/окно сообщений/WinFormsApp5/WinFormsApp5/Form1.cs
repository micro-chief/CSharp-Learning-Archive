namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Вариантов нет, всего одна кнопка :( ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            textBox1.Text = "Вы нажали ОК";
            this.TopMost = true; // Ставим нашу форму поверх всех окон 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes) // Проверяем какая кнопка нажата ...
                textBox1.Text = "Вы нажали ДА";
            else
                textBox1.Text = "Вы нажали НЕТ";
            this.TopMost = true; // Ставим нашу форму по верх всех окон 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Выберите один из вариантов", "Сообщение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (DialogResult == DialogResult.Yes)
                textBox1.Text = "Вы нажали ДА";
            if (DialogResult == DialogResult.No)
                textBox1.Text = "Вы нажали НЕТ";
            if (DialogResult == DialogResult.Cancel)
                textBox1.Text = "Вы нажали ОТМЕНА";
            this.TopMost = true;
        }
    }
}