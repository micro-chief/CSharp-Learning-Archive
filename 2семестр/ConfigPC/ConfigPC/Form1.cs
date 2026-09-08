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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ConfigPC
{
    public partial class Form1 : Form
    {
        int count, cost0, cost1, cost2, cost3, cost4, cost5, cost6, cost7;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = cost0 + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7;
            MessageBox.Show(count.ToString() + "₽", "Цены огонь");
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    cost0 = 5000;
                    break;
                case 1:
                    cost0 = 4000;
                    break;
                case 2:
                    cost0 = 8990;
                    break;
                case 3:
                    cost0 = 9900;
                    break;
                case 4:
                    cost0 = 6666;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    cost1 = 7890;
                    break;
                case 1:
                    cost1 = 14900;
                    break;
                case 2:
                    cost1 = 7895;
                    break;
                case 3:
                    cost1 = 13245;
                    break;
                case 4:
                    cost1 = 150;
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    cost2 = 2038;
                    break;
                case 1:
                    cost2 = 5531;
                    break;
                case 2:
                    cost2 = 4127;
                    break;
                case 3:
                    cost2 = 5208;
                    break;
                case 4:
                    cost2 = 5340;
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    cost3 = 8561;
                    break;
                case 1:
                    cost3 = 8956;
                    break;
                case 2:
                    cost3 = 5689;
                    break;
                case 3:
                    cost3 = 6584;
                    break;
                case 4:
                    cost3 = 211;
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    cost4 = 6458;
                    break;
                case 1:
                    cost4 = 9458;
                    break;
                case 2:
                    cost4 = 3104;
                    break;
                case 3:
                    cost4 = 6458;
                    break;
                case 4:
                    cost4 = 1;
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    cost5 = 8965;
                    break;
                case 1:
                    cost5 = 9457;
                    break;
                case 2:
                    cost5 = 6549;
                    break;
                case 3:
                    cost5 = 9546;
                    break;
                case 4:
                    cost5 = 2;
                    break;
                case 5:
                    cost5 = 290000;
                    break;

            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    cost6 = 646561;
                    break;
                case 1:
                    cost6 = 84586;
                    break;
                case 2:
                    cost6 = 6253;
                    break;
                case 3:
                    cost6 = 94757;
                    break;
                case 4:
                    cost6 = 3;
                    break;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedIndex)
            {
                case 0:
                    cost7 = 8561;
                    break;
                case 1:
                    cost7 = 8956;
                    break;
                case 2:
                    cost7 = 5689;
                    break;
                case 3:
                    cost7 = 6584;
                    break;
                case 4:
                    cost7 = 211;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            StreamReader read = new StreamReader(openFileDialog1.FileName);
            string[] r = read.ReadToEnd().Split('\n');
            for (int i = 0; i < r.Length; i++)
            {
                comboBox1.SelectedItem = r[0];
                comboBox2.SelectedItem = r[1];
                comboBox3.SelectedItem = r[2];
                comboBox4.SelectedItem = r[3];
                comboBox5.SelectedItem = r[4];
                comboBox6.SelectedItem = r[5];
                comboBox7.SelectedItem = r[6];
                comboBox8.SelectedItem = r[7];
            }
            read.Close();
            MessageBox.Show("File is Opened");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string matherboard;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            matherboard = comboBox1.Text +
            "\n" + comboBox2.Text +
            "\n" + comboBox3.Text +
            "\n" + comboBox4.Text +
            "\n" + comboBox5.Text +
            "\n" + comboBox6.Text +
            "\n" + comboBox7.Text +
            "\n" + comboBox8.Text + "\n";

            StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName);
            myStream.WriteLine(matherboard);
            myStream.Close();
            MessageBox.Show("File is Saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
