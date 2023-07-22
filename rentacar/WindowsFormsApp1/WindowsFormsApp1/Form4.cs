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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\araclistesi.accdb");
        OleDbCommand komut;
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();


        

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void Form4_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int para = 0,a = 0;
            TimeSpan hesap = dateTimePicker2.Value - dateTimePicker1.Value;
            a = Convert.ToInt32(hesap.Days);
            if(textBox2.Text == "RENAULT")
            { 
            if (a < 7)
                para = a * 1000;
            if (a >= 7 && a <= 15)
                para = a * 800;
            if (a > 15 && a <= 30)
                para = a * 600;
            if (a > 30)
                para = a * 300;
                textBox5.Text = para.ToString();
            }

            if (textBox2.Text == "FİAT")
            {
                if (a < 7)
                    para = a * 800;
                if (a >= 7 && a <= 15)
                    para = a * 600;
                if (a > 15 && a <= 30)
                    para = a * 400;
                if (a > 30)
                    para = a * 200;
                textBox5.Text = para.ToString();
            }
            if (textBox2.Text == "OPEL")
            {
                if (a < 7)
                    para = a * 500;
                if (a >= 7 && a <= 15)
                    para = a * 300;
                if (a > 15 && a <= 30)
                    para = a * 200;
                if (a > 30)
                    para = a * 150;
                textBox5.Text = para.ToString();
            }
            if (textBox2.Text == "")
                MessageBox.Show("Araç Seçiniz");
            a = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE araclar SET kira=@kira WHERE id=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), baglanti);
            cmd.Parameters.AddWithValue("@kira", "kirada");        
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["plaka"].Value.ToString();
            textBox4.Text = satır.Cells["model"].Value.ToString();
            textBox2.Text = satır.Cells["marka"].Value.ToString();
            textBox3.Text = satır.Cells["seri"].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
          
        }



    }
}
