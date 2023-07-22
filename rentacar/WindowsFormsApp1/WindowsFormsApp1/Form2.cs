using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\araclistesi.accdb");
        OleDbCommand komut;
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            listele();
            arama();
            arama2();
        }
        private void listele()
        {
            table.Clear();
            baglanti.Open();
            komut = new OleDbCommand("select * from araclar", baglanti);
            adtr = new OleDbDataAdapter(komut);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
            dataGridView1.Columns[0].HeaderText = "kayitnumarasi";

           
        }
        private void arama()
        {
            baglanti.Open();
            komut = new OleDbCommand("select * from araclar where kira= 'kirada'", baglanti);
            adtr = new OleDbDataAdapter(komut);
            DataTable table2 = new DataTable();
            adtr.Fill(table2);
            dataGridView2.DataSource = table2;
            baglanti.Close();
            dataGridView2.Columns[0].HeaderText = "kayitnumarasi";




        }

        private void arama2()
        {
            baglanti.Open();
            komut = new OleDbCommand("select * from araclar where kira= 'müsait'", baglanti);
            adtr = new OleDbDataAdapter(komut);
            DataTable table2 = new DataTable();
            adtr.Fill(table2);
            dataGridView3.DataSource = table2;
            baglanti.Close();
            dataGridView3.Columns[0].HeaderText = "kayitnumarasi";




        }
    }
}
