using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool isFileChanged;
        public Form1()
        {
            InitializeComponent();
            Init();
            UpdateTextWithTitle();

        }
        public void Init()
        {
            filename = "";
            this.isFileChanged = false;
        }

        private void новыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            richTextBox1.Text = "";
            filename = "";
            UpdateTextWithTitle();
        }

        private void можноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void ненадаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            Form2 pass=new Form2(); 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pass.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        richTextBox1.Text = sr.ReadToEnd();
                        sr.Close();
                        filename = openFileDialog1.FileName;
                    }
                    catch
                    {
                        MessageBox.Show("Невозмжно открыть файл");
                    }
                }
            }
           
            UpdateTextWithTitle();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Savefile(filename);
        }
        private void Savefile(string _filename)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string file;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            file = richTextBox1.Text;

            StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);
            myStream.WriteLine(file);
            myStream.Close();
            MessageBox.Show("File is Saved");
            UpdateTextWithTitle();
        }

        private void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = 
                    MessageBox.Show("Сохранить файл?", 
                    "Сохранение файла", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question, 
                    MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes)
                {
                    Savefile(filename);
                }
            }
        }
        public void OnTextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace('*', ' ');
                this.isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
        public void UpdateTextWithTitle()
        {
            if
                (filename != "")
                this.Text = filename + " - Заметки";
            else
                this.Text = "Безымянный - Заметки";
        }


        private void датаИВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now;
        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }


        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.White;
            menuStrip1.BackColor = Color.SeaShell;
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
            richTextBox1.BackColor = Color.Gray;
            menuStrip1.BackColor = Color.DarkGray;
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
