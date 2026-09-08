using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace еще_одна_залупа_с_кодом_V1
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

        private void выхоэдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filee;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filee = textBox1.Text;

            StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);
            myStream.WriteLine(filee);
            myStream.Close();
            MessageBox.Show("File is Saved");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            StreamReader read = new StreamReader(openFileDialog1.FileName);
             textBox1.Text = read.ReadToEnd();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OUT OF ORDER", "SORRY");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
