using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void кот1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\1СИСАД2\\сам делал\\pisanina\\c#\\меню\\cat1.png");
        }

        private void кот2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\1СИСАД2\\сам делал\\pisanina\\c#\\меню\\cat2.png");
        }

        private void кот3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("E:\\1СИСАД2\\сам делал\\pisanina\\c#\\меню\\cat3.png");
        }
    }
}