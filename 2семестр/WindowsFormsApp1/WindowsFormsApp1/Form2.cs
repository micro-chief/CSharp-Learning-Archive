using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string passWord;
        public Form2()
        {
            InitializeComponent();
        }
        string password = "1111";
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text != password)
            {
                string result = string.Format("{0}\n{1}", "Не верный пароль!");
                MessageBox.Show(result, "Error!");               
                return;
            }
            else
            {
                string result = string.Format("{0}\n{1}", "Пароль верный!", "СБЭУ, работаем.");
                MessageBox.Show(result, "Наааайк!");
                DialogResult= DialogResult.OK;
            }
        }
    }
}
