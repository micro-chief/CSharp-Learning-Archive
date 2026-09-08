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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://" + comboBox1.Text);
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13)) // Проверяем нажата ли клавиша Enter (код 13). Аргумент е - код нажатой клавиши
            {
                button4_Click(sender, e); // Если Enter нажат, то вызываем событие нажатия на кнопку "Перейти"
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button5.Visible = false;
            textBox2.Text = comboBox1.Text;
            
            listBox1.Items.Clear(); // Очищаем список от содержимого
            
            using (StreamReader reader = new StreamReader("C:\\browser.ini")) // Создаём переменную reader для чтения из файла browser.ini
            {
                
                string z = reader.ReadLine(); // Считываем первую строку чтобы получить число строк в списке
                for (int j = 0; j < Convert.ToDouble(z); j++) //В цикле считываем остальные строки из
                    listBox1.Items.Add(reader.ReadLine());
                {

                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            button5.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text + "|" + textBox2.Text); //Добавляем в список адрес и комментарий. Символ вертикальная черта будет в последующем использоваться как разделитель комментария и адреса сайта



            using (StreamWriter sw = new StreamWriter("C:\\browser.ini")) // Создаём переменную sw для записи данных в поток (файл)
            { 
                sw.WriteLine(listBox1.Items.Count.ToString()); // Первой строкой записываем в файл число строк в нашем списке
                for (int j = 0; j < listBox1.Items.Count; j++) // В цикле записываем все строки в файл. Count - число строк в списке
                    sw.WriteLine(listBox1.Items[j]);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            string newstr = "";

            int flag = 0; //flag определяет разделитель |
            char c;
            int k = str.Length;
            for (int j = 0; j < k; j++) //Выделяем из строки адрес сайта
            {
                c = str[j];
                if (flag != 0) newstr += c;
                if (c == '|') flag = 1;
            }
            comboBox1.Text = newstr; //Подставляем в адресную строку адрес сайта
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) // Проверяем, есть ли в списке выделенная строка
                MessageBox.Show("Нет выделенной строки"); // Если нет, то выводим сообщение.
            else 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); // Иначе .. Удаляем выделенную строку
            using (StreamWriter sw = new StreamWriter("C:\\browser.ini")) //Сохраняем новый список в файле
            {
                sw.WriteLine(listBox1.Items.Count.ToString());
                for (int j = 0; j < listBox1.Items.Count; j++)
                    sw.WriteLine(listBox1.Items[j]);
            }
        }
    }
    
}
