using System;
using System.Windows.Forms;

namespace Sports_source
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            this.Hide();
            clients.ShowDialog();
        }

        private void training_Click(object sender, EventArgs e)
        {
            Training training = new Training();
            this.Hide();
            training.ShowDialog();
        }

        private void subscription_Click(object sender, EventArgs e)
        {
            Subscription subscription = new Subscription();
            this.Hide();
            subscription.ShowDialog();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.ShowDialog();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
