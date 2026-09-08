using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sports_source
{
    public partial class Training : Form
    {
        OleDbConnection dbconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\1СИСАД2\\сам делал\\pisanina\\курсач\\Sports_source\\курсовая БД.accdb\"");
        OleDbDataAdapter dba;
        DataSet ds;
        public Training()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            dbconn.Open();
            dba = new OleDbDataAdapter("Select * From Занятия", dbconn);
            ds = new DataSet();
            dba.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dbconn.Close();
        }
        private void Reload_Data()
        {
            ds.Tables[0].Clear();
            Load_Data();
        }
        private void update_zanyatia_btn_Click(object sender, EventArgs e)
        {
            Reload_Data();
        }
        private void Training_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void add_zanyatie_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"insert into Занятия values ('{int.Parse(id_zanyatia.Text)}', " +
                $"'{nazvanie_zanyatia.Text}', '{trener_zanyatia.Text}', '{data_provedenia_zanyatia.Text}', '{mesto_provedenia_zanyatia.Text}')";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            id_zanyatia.Clear();
            nazvanie_zanyatia.Clear();
            trener_zanyatia.Clear();
            data_provedenia_zanyatia.Clear();
            mesto_provedenia_zanyatia.Clear();
        }
        private void delete_btn_zanyatie_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"Delete from Занятия where [ID Занятия] = Number";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.SmallInt).Value = int.Parse(delete_id_zanyatia.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            delete_id_zanyatia.Clear();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void izmenit_zanyatia_btn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = "update Занятия set [Дата проведения] = Number where [ID занятия] = IDzan";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.WChar).Value = izmenenie_data_zanyatia.Text;
            cmd.Parameters.Add("IDzan", OleDbType.SmallInt).Value = int.Parse(izmenenie_id_zanyatia.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            izmenenie_data_zanyatia.Clear();
            izmenenie_id_zanyatia.Clear();
        }
    }
}
