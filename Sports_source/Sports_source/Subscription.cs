using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sports_source
{
    public partial class Subscription : Form
    {
        OleDbConnection dbconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\1СИСАД2\\сам делал\\pisanina\\курсач\\Sports_source\\курсовая БД.accdb\"");
        OleDbDataAdapter dba;
        DataSet ds;
        public Subscription()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            dbconn.Open();
            dba = new OleDbDataAdapter("Select * From Абонементы", dbconn);
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
        private void Subscription_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void update_abon_btn_Click(object sender, EventArgs e)
        {
            Reload_Data();
        }
        private void add_abon_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"insert into Абонементы values ('{int.Parse(id_abon.Text)}', " +
                $"'{kurs.Text}', '{data_nachala_abon.Text}', '{data_okonch_abon.Text}', '{stoimost_abon.Text}')";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            id_abon.Clear();
            kurs.Clear();
            data_nachala_abon.Clear();
            stoimost_abon.Clear();
            stoimost_abon.Clear();
        }
        private void delete_abon_btn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"Delete from Клиенты where [ID Клиента] = Number";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.SmallInt).Value = int.Parse(delete_abon.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            delete_abon.Clear();
        }
        private void izmenenie_abon_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = "update Абонементы set Стоимость = Number where [ID Абонемента] = IDabon";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.WChar).Value = stoimost_izmenenie.Text;
            cmd.Parameters.Add("IDabon", OleDbType.SmallInt).Value = int.Parse(id_abon_izmenenie.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            stoimost_izmenenie.Clear();
            id_abon_izmenenie.Clear();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
