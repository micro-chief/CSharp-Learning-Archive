namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToLongDateString();
            textBox1.Text = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.TodayDate = new DateTime(2016, 09, 1); // устанавливаем новую 
            monthCalendar1.ShowToday = false; // убираем текущую дату снизу 
            monthCalendar1.SelectionStart = new DateTime(2016, 09, 1); // выделяем синим новую дату
            monthCalendar1.SelectionEnd = new DateTime(2016, 09, 1);
            monthCalendar1.ShowWeekNumbers = true; //показываем дней недели и номер недели
        }
    }
}