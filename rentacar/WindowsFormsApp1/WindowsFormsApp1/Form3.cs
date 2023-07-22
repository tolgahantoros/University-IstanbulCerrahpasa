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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }


        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\bilgiler.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        int id;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.Text != "" && textBox5.Text != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = ("INSERT INTO bilgiler (tc,ad,soyad,dogum,meslek,cepno,evno,email,adres,ehliyetno,notlar) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + maskedTextBox1.Text.ToString() + "','" + maskedTextBox2.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + richTextBox1.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + richTextBox2.Text.ToString() + "')");
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kaydınız başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ds.Clear();
                listele();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                pictureBox1.Image = null;

            }
            else
            {
                MessageBox.Show("* Alanları Boş Geçmeyiniz!");
            }
        }
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM bilgiler", baglanti);
            adtr.Fill(ds, "bilgiler");
            dataGridView1.DataSource = ds.Tables["bilgiler"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            listele();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result3 == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM bilgiler  WHERE id=@id";
                komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                ds.Clear();
                listele();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
            }
            else { }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "UPDATE bilgiler SET tc='" + textBox1.Text + "',ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "', dogum='" + dateTimePicker1.Text + "',meslek='" + textBox4.Text + "',cepno='" + maskedTextBox1.Text + "',evno='" + maskedTextBox2.Text + "',email='" + textBox5.Text + "',adres='" + richTextBox1.Text + "',ehliyetno='" + textBox6.Text + "',notlar='" + richTextBox2.Text + "' WHERE id=" + id;
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Başarıyla Güncellendi!", "Başarılı", MessageBoxButtons.OK);
            ds.Clear();
            listele();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            pictureBox1.Image = null;
        }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            textBox1.Text = satır.Cells["tc"].Value.ToString();
            textBox2.Text = satır.Cells["ad"].Value.ToString();
            textBox3.Text = satır.Cells["soyad"].Value.ToString();
            dateTimePicker1.Text = satır.Cells["dogum"].Value.ToString();
            textBox4.Text = satır.Cells["meslek"].Value.ToString();
            maskedTextBox1.Text = satır.Cells["cepno"].Value.ToString();
            maskedTextBox2.Text = satır.Cells["evno"].Value.ToString();
            richTextBox1.Text = satır.Cells["adres"].Value.ToString();
            textBox5.Text = satır.Cells["email"].Value.ToString();
            textBox6.Text = satır.Cells["ehliyetno"].Value.ToString();
            richTextBox2.Text = satır.Cells["notlar"].Value.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Title = "Resim Ekle";
            fd.Filter = " (*.jpg)|*.jpg|(*.png)|*.png ";
            fd.ShowDialog();
            string DosyaYolu = fd.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;



        }
    }
}
