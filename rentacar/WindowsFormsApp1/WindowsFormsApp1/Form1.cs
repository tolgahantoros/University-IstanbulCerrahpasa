using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                label3.Text = "Giriş Yapılıyor...";
                this.timer1.Start();

            }
            else
                MessageBox.Show("Kullanıcı adı ve şifre yanlış.");

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 50;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            this.progressBar1.Increment(3);
            if (progressBar1.Value > 49)
            {
                MDIParent1 yeni = new MDIParent1();
                yeni.Show();
                this.Hide();
                timer1.Stop();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}