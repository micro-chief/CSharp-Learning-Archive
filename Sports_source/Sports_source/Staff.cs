using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sports_source
{
    public partial class Staff : Form
    {
        OleDbConnection dbconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"E:\\1СИСАД2\\сам делал\\pisanina\\курсач\\Sports_source\\курсовая БД.accdb\"");
        OleDbDataAdapter dba;
        DataSet ds;
        public Staff()
        {
            InitializeComponent();
        }
        private void Load_Data()
        {
            dbconn.Open();
            dba = new OleDbDataAdapter("Select * From Персонал", dbconn);
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
        private void Staff_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void add_rabotnika_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"insert into Персонал values ('{int.Parse(id_rabotnika.Text)}', " +
                $"'{FIO_rabotnika.Text}', '{dolzhnost_rabotnika.Text}', '{specialnocst_rabotnika.Text}', '{grafik_rabotnika.Text}', '{nomer_phone.Text}', '{zp_rabotnika.Text}')";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            id_rabotnika.Clear();
            FIO_rabotnika.Clear();
            dolzhnost_rabotnika.Clear();
            grafik_rabotnika.Clear();
            nomer_phone.Clear();
            zp_rabotnika.Clear();
        }
        private void delete_id_btn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = $"Delete from Персонал where [ID Работника] = Number";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.SmallInt).Value = int.Parse(delete_id_rabotnika.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            delete_id_rabotnika.Clear();
        }
        private void izmnenie_btn_Click(object sender, EventArgs e)
        {
            dbconn.Open();
            string qry = "update Персонал set ЗП = Number where [ID Работника] = IDrab";
            OleDbCommand cmd = new OleDbCommand(qry, dbconn);
            cmd.Parameters.Add("Number", OleDbType.WChar).Value = izmenenie_zp_rabotnika.Text;
            cmd.Parameters.Add("IDrab", OleDbType.SmallInt).Value = int.Parse(izmenenie_id_rabotnika.Text);
            cmd.ExecuteNonQuery();
            dbconn.Close();
            Reload_Data();
            izmenenie_id_rabotnika.Clear();
            izmenenie_id_rabotnika.Clear();
        }
    }
}
