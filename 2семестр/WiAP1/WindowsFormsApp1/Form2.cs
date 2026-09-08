using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string passWord;
        public Form2()
        {
            InitializeComponent();
            textBox1.MaxLength = 4;
            this.Load += delegate
            {
                passWord = "1111";
            };
            button1.Click += delegate
            {

                if (textBox1.Text != passWord)
                {
                    string result = string.Format("{0}\n{1}", "Не верный пароль!", "Работа программы будет завершена!");
                    MessageBox.Show(result, "Error!");
                    Application.Exit();
                    return;
                }
                else
                {
                    string result = string.Format("{0}\n{1}", "Пароль верный!", "СБЭУ, работаем.");
                    MessageBox.Show(result, "Наааайк!");
                    this.Close();
                }

            };
        }
    }
}
