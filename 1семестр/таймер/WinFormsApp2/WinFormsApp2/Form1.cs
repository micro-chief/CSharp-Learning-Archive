namespace WinFormsApp2
{
    public partial class timer : Form
    {
        int d = 1;
        public timer()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Left = pictureBox1.Left + d; //изменяем расстояние до края формы
            if (pictureBox1.Left >= 640 || pictureBox1.Left <= 0) //если достигнут левый или правый край формы
            {

                if (d > 0) pictureBox1.Image = Image.FromFile("E:\\1СИСАД2\\сам делал\\pisanina\\c#\\таймер\\Ris2.png"); //в зависимости от того куда двигались, 
                if (d < 0) pictureBox1.Image = Image.FromFile("E:\\1СИСАД2\\сам делал\\pisanina\\c#\\таймер\\Ris1.png"); //меняем рисунок
                d = -d; //изменяем направление движения
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (d >= 0) d = trackBar1.Value;
            if (d < 0) d = -trackBar1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}