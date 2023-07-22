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
    public partial class formaraclisteleme : Form
    {
        public formaraclisteleme()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\araclistesi.accdb");
        OleDbCommand komut;
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataTable table = new DataTable();

        private void sadeceSayi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {





        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE araclar SET plaka=@plaka, marka=@marka, seri=@seri, model=@model, yakit=@yakit, vites=@vites, renk=@renk, sonkm=@sonkm, motor=@motor, kasa=@kasa, kira=@kira WHERE id=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), baglanti);
            cmd.Parameters.AddWithValue("@plaka", textBox1.Text);
            cmd.Parameters.AddWithValue("@marka", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@seri", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@model", Convert.ToInt32(textBox2.Text));
            cmd.Parameters.AddWithValue("@yakit", comboBox3.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@vites", comboBox4.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@renk", comboBox5.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sonkm", Convert.ToInt32(textBox3.Text));
            cmd.Parameters.AddWithValue("@motor", comboBox6.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@kasa", comboBox7.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@kira", comboBox8.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            listele();
            MessageBox.Show("Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["plaka"].Value.ToString();
            textBox2.Text = satır.Cells["model"].Value.ToString();
            textBox3.Text = satır.Cells["sonkm"].Value.ToString();
            comboBox1.Text = satır.Cells["marka"].Value.ToString();
            comboBox2.Text = satır.Cells["seri"].Value.ToString();
            comboBox3.Text = satır.Cells["yakit"].Value.ToString();
            comboBox4.Text = satır.Cells["vites"].Value.ToString();
            comboBox5.Text = satır.Cells["renk"].Value.ToString();
            comboBox6.Text = satır.Cells["motor"].Value.ToString();
            comboBox7.Text = satır.Cells["kasa"].Value.ToString();
            comboBox8.Text = satır.Cells["kira"].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void formaraclisteleme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM araclar  WHERE id=@id";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                if (comboBox1.SelectedIndex == 0)
                {
                    comboBox2.Items.Add("Astra");
                    comboBox2.Items.Add("Corsa");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    comboBox2.Items.Add("Egea");
                    comboBox2.Items.Add("Linea");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox2.Items.Add("TOROS");
                    comboBox2.Items.Add("Megane");
                }
            }
            catch
            {

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void formaraclisteleme_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
