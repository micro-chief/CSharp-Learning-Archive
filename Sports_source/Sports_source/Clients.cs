using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sports_source
{
    public partial class Clients : Form
    {
        OleDbConnection dbconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\1СИСАД2\\сам делал\\pisanina\\курсач\\Sports_source\\курсовая БД.accdb\"");
        OleDbDataAdapter dba;
        DataSet ds;
        public Clients()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            dbconn.Open();
            dba = new OleDbDataAdapter("Select * From Клиенты", dbconn);
            ds = new DataSet();
            dba.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dbconn.Close();
        }
        private void Reload_Data()
        {
            ds.Tables[0].Clear();
            Load_Data();
        }
        private void Clients_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void btn_update_client_Click(object sender, EventArgs e)
        {
            Reload_Data();
        }
        private void client_delete_btn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"Delete from Клиенты where [ID Клиента] = Number";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.SmallInt).Value = int.Parse(delete_client_pole.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            delete_client_pole.Clear();
        }
        private void add_client_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"insert into Клиенты values ('{int.Parse(id_client.Text)}', " +
                $"'{FIO_client.Text}', '{client_number_phone.Text}', '{client_el_pochta.Text}', '{client_data_zanyatia.Text}', '{client_comment.Text}')";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            id_client.Clear();
            FIO_client.Clear();
            client_number_phone.Clear();
            client_data_zanyatia.Clear();
            client_comment.Clear();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void izmenit_client_btn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = "update Клиенты set [Номер телефона] = Number where [ID Клиента] = IDcli";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.WChar).Value = izmenenie_telephona_client.Text;
            cmd.Parameters.Add("IDcli", OleDbType.SmallInt).Value = int.Parse(izmenenie_id_client.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            izmenenie_telephona_client.Clear();
            izmenenie_id_client.Clear();
        }
    }
}
